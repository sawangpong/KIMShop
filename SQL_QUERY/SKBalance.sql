SELECT  DISTINCT 
st.ITEMNO,st.ITEMNAME, st.SK_UNIT,
'ON-HAND' = (select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'SR' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE),
'Booking'=  ISNULL((select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'BK' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE) ,0),
'Available' = (select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'SR' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE) - ISNULL((select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'BK' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE) ,0),
'ON-Order' = ISNULL((select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'SP' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE),0),
'Uint-Cost' = (select sum(str.SKT_TOTALAMT) from SKTRANS str WHERE str.SK_CODE = 'SR' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE)/(select sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'SR' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE),
'Total-value' = (select sum(str.SKT_TOTALAMT) from SKTRANS str WHERE str.SK_CODE = 'SR' AND str.ITEMNO = st.ITEMNO  GROUP BY SK_CODE),
'last-update' = max(st.LastUpdate)
FROM SKTRANS st
GROUP BY st.ITEMNO,st.ITEMNAME, st.SK_UNIT



--select str.ITEMNO, sum(str.SKT_QTY) from SKTRANS str WHERE str.SK_CODE = 'BK'   GROUP BY SK_CODE,str.ITEMNO