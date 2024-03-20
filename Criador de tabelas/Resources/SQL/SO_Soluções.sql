CREATE PROC SO_Soluções       
@object_type nvarchar(20),    -- SBO Object Type        
@transaction_type nchar(1),   -- [A]dd, [U]pdate, [D]elete, [C]ancel, C[L]ose        
@num_of_cols_in_key int,        
@list_of_key_cols_tab_del nvarchar(255),        
@list_of_cols_val_tab_del nvarchar(255),        
@error int output,        
@error_message nvarchar (200) output

  


/*
	Procedure utilizada no Add-on SO Solutions
	Autor: Igor Oliveira	
*/

AS


--/* Aprovação de Pedido - Documento de Marketing */
IF @object_type IN ('540000006') AND @transaction_type IN ('A','U')

BEGIN 

	 DECLARE @UserId BIGINT;
	 DECLARE @DataSource AS NVARCHAR(5) = '';
	 DECLARE @DataLib as DATETIME = NULL;

	/* Parametro ativo para usar aprovação do Add-on */

	IF (SELECT 'TRUE' FROM [@SOCONF] WHERE U_SO_UtilizaAprovacaoPed = 'Y') = 'TRUE'

	BEGIN 
		IF @object_type = '540000006'

		SELECT 
		@USERID = CASE @transaction_type WHEN 'A' THEN T0.UserSign ELSE T0.UserSign2 END,
		@DataSource = T0.DataSource,
		@DataLib = T0.DocDate

		FROM OPQT T0 
		JOIN PQT1 T1 ON T1.DocEntry = T0.DocEntry
		WHERE T0.DocEntry = @list_of_cols_val_tab_del

		
		BEGIN 
			IF @transaction_type = 'A'
			EXEC [SO_AprovPedidos_proc] @object_type , @list_of_cols_val_tab_del , @UserId, 'TRUE'
		END

	END
	
END

