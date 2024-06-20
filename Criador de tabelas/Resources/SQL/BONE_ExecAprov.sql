CREATE PROC [BONE_ExecAprov] @UserAprov int 

AS

/*	
	Procedure utilizada para aprovação de documentos. 
	Autor: Igor Oliveira
*/

SELECT 
		'' as 'Sel',
		T0.U_BOneDocDate [DocDate],
		CASE WHEN T0.U_BOneTipoDoc = '17' THEN 'Pedido de venda'
		WHEN T0.U_BOneTipoDoc = '540000006' THEN 'Oferta de compra'
		WHEN T0.U_BOneTipoDoc = '22' THEN 'Pedido de compra' END AS [TipoDoc],
		T0.U_BOneNumDoc [DocEntry],
		T0.U_BOneCardCode [CardCode],
		T0.U_BOneCardName [CardName], 
		T0.U_BOneBplName [BplName],
		(SELECT a.SlpName FROM OSLP A WHERE A.SlpCode = T0.U_BOneSlpCode) [SlpName],
		T0.U_BOneNameEtapa [NameEtapa],
		T2.UserID [UserAprove],
		T0.U_BOneModeloAut [ModeloAut], 
		(SELECT b.PymntGroup FROM OCTG B WHERE B.GroupNum = T0.U_BOnePaymentCode) [PaymentName],
		T0.U_BOnePaymentMethod [PaymentMethod], 
		T0.U_BOneDocTotal [DocTotal],
		'' AS [Status]

FROM [@BONEAPROV] T0 WITH(NOLOCK)
JOIN OWST T1 WITH(NOLOCK) ON T1.WstCode = T0.U_BOneCodEtapa
JOIN WST1 T2 WITH(NOLOCK) ON T2.WstCode = T1.WstCode
WHERE (T0.U_BOneAutorizado = 'FALSE' AND T0.U_BOneProcessado = 0)
AND T2.UserID = @UserAprov