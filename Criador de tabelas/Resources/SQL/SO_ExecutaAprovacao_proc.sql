CREATE PROC SO_ExecutaAprovacao_proc
@Pedido AS INT  
,@Status AS NVARCHAR(1)  
,@Usuario AS INT  
,@Modelo AS NVARCHAR(254)
,@DocType AS INT
,@Etapa AS NVARCHAR(254)
,@Texto As NVARCHAR(MAX) = NULL
,@UserCode As NVARCHAR(MAX) = NULL
											
As  
Begin  

	IF (@UserCode IS NOT NULL)
	BEGIN
		SET @Usuario = (SELECT "USERID" FROM OUSR WHERE "USER_CODE" = @UserCode)
	END
  
 If (@Status = 'A')  
    Begin  
  
	   Update [@SOAPROVPED]   
	   Set   
		 U_Autorizado = 'TRUE',  
		 U_DataLib = Convert(date, getdate()),  
		 U_HoraLib = CAST(REPLACE(CONVERT(VARCHAR(5), getdate(), 108), ':', '') AS BIGINT),  
		 "U_Texto" = @Texto
		  Where   
		  U_DocEntry = @Pedido   
		 And U_Aprovador = @Usuario  
		 And U_Modelo = @Modelo  
		 And U_DocType = @DocType
		 And U_Etapa = @Etapa
	   
	   
	   IF
	   (SELECT COUNT(*)   
	    FROM [@SOAPROVPED] T0   
	    WHERE T0.U_DocEntry = @Pedido  
	    And T0.U_Autorizado = 'TRUE'   
		And T0.U_DocType = @DocType
		And T0.U_Etapa = @Etapa
		AND T0.U_Modelo = @Modelo
	    GROUP BY T0.U_Modelo,T0.U_QtdAprov) >= (SELECT DISTINCT T0x.U_QtdAprov FROM [@SOAPROVPED] T0x WHERE T0x.U_DocEntry = @Pedido AND T0x.U_DocType = @DocType AND T0x.U_Etapa = @Etapa AND T0x.U_Modelo = @Modelo)
  
		Begin
		 UPDATE [@SOAPROVPED]
		 SET U_StatusEtapa = 'TRUE'
		 WHERE U_DocEntry = @Pedido  
		   And U_DocType = @DocType
		   And U_Etapa = @Etapa
		   And U_Modelo = @Modelo
		end

	   Declare @SUM_MODELOS TABLE
	   (
		  EtapasTotal int,
		  EtapasAprovadas int
	   )


	   Insert into @SUM_MODELOS 
	   SELECT COUNT(DISTINCT T0.U_Etapa)  ,0 
	    FROM [@SOAPROVPED] T0   
	    WHERE T0.U_DocEntry = @Pedido 
		And T0.U_DocType = @DocType
		
		UPDATE @SUM_MODELOS
		SET EtapasAprovadas =  (SELECT COUNT(DISTINCT T0.U_Etapa)   
								FROM [@SOAPROVPED] T0   
								WHERE T0.U_DocEntry = @Pedido 
								And T0.U_StatusEtapa = 'TRUE'
								And T0.U_DocType = @DocType)

  
	   If (Select EtapasTotal From @SUM_MODELOS)  = (Select EtapasAprovadas From @SUM_MODELOS) 

	   Begin
	    Select 'TRUE'  
	   End  
	   Else	     
	   Begin
		  Select 'PENDENTE'  
	   End  
 End  
  
 if (@Status = 'R')  
    Begin  
  
			Update [@SOAPROVPED]   
			Set U_Autorizado = 'FALSE',  
			U_DataLib = Convert(date, getdate()),  
			U_HoraLib = CAST(REPLACE(CONVERT(VARCHAR(5), getdate(), 108), ':', '') AS BIGINT),
			"U_Texto" = @Texto
			Where   
				U_DocEntry = @Pedido   
			And U_Aprovador = @Usuario  
			And U_Modelo = @Modelo  
			And U_DocType = @DocType 
		    And U_Etapa = @Etapa
    
	IF
	   (SELECT COUNT(*)   
	    FROM [@SOAPROVPED] T0   
	    WHERE T0.U_DocEntry = @Pedido  
	    And T0.U_Autorizado = 'FALSE'   
		And T0.U_DocType = @DocType
		And T0.U_Etapa = @Etapa
		And T0.U_Modelo = @Modelo
	    GROUP BY T0.U_Modelo,T0.U_QtdReprov) >= (SELECT DISTINCT T0x.U_QtdReprov FROM [@SOAPROVPED] T0x WHERE T0x.U_DocEntry = @Pedido AND T0x.U_DocType = @DocType AND T0x.U_Etapa = @Etapa AND T0x.U_Modelo = @Modelo)
  
		Begin
		 UPDATE [@SOAPROVPED]
		 SET U_StatusEtapa = 'FALSE'
		 WHERE U_DocEntry = @Pedido  
		   And U_DocType = @DocType
		   And U_Etapa = @Etapa
		   And U_Modelo = @Modelo
		end

	   Declare @SUM_MODELOSREPROVADOS TABLE
	   (
		  EtapasTotal int,
		  EtapasReprovadas int
	   )


	   Insert into @SUM_MODELOSREPROVADOS 
	   SELECT COUNT(DISTINCT T0.U_Etapa)  ,0 
	    FROM [@SOAPROVPED] T0   
	    WHERE T0.U_DocEntry = @Pedido 
		And T0.U_DocType = @DocType
		
		UPDATE @SUM_MODELOSREPROVADOS
		SET EtapasReprovadas =  (SELECT COUNT(DISTINCT T0.U_Etapa)   
								FROM [@SOAPROVPED] T0   
								WHERE T0.U_DocEntry = @Pedido 
								And T0.U_StatusEtapa = 'FALSE'
								And T0.U_DocType = @DocType)

  
	   If (Select EtapasTotal From @SUM_MODELOSREPROVADOS)  = (Select EtapasReprovadas From @SUM_MODELOSREPROVADOS) 

	   Begin
	    Select 'FALSE'  
	   End  
	   Else	     
	   Begin
		  Select 'PENDENTE'  
	   End  
	
	End
  
End