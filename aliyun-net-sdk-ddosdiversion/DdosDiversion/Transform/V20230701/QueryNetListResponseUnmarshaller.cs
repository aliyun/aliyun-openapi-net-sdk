/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.DdosDiversion.Model.V20230701;

namespace Aliyun.Acs.DdosDiversion.Transform.V20230701
{
    public class QueryNetListResponseUnmarshaller
    {
        public static QueryNetListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryNetListResponse queryNetListResponse = new QueryNetListResponse();

			queryNetListResponse.HttpResponse = _ctx.HttpResponse;
			queryNetListResponse.Code = _ctx.LongValue("QueryNetList.Code");
			queryNetListResponse.RequestId = _ctx.StringValue("QueryNetList.RequestId");
			queryNetListResponse.Message = _ctx.StringValue("QueryNetList.Message");

			List<QueryNetListResponse.QueryNetList_DataItem> queryNetListResponse_data = new List<QueryNetListResponse.QueryNetList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryNetList.Data.Length"); i++) {
				QueryNetListResponse.QueryNetList_DataItem dataItem = new QueryNetListResponse.QueryNetList_DataItem();
				dataItem.Total = _ctx.LongValue("QueryNetList.Data["+ i +"].Total");
				dataItem.Page = _ctx.LongValue("QueryNetList.Data["+ i +"].Page");
				dataItem.Num = _ctx.LongValue("QueryNetList.Data["+ i +"].Num");

				List<QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data> dataItem_nets = new List<QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data>();
				for (int j = 0; j < _ctx.Length("QueryNetList.Data["+ i +"].Nets.Length"); j++) {
					QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data data = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data();
					data.UserId = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].UserId");
					data.SaleId = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].SaleId");
					data.UpstreamType = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].UpstreamType");
					data.Net = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].Net");
					data.NetType = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].NetType");
					data.Mode = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].Mode");
					data.DeclaredState = _ctx.IntegerValue("QueryNetList.Data["+ i +"].Nets["+ j +"].DeclaredState");
					data.GmtCreate = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].GmtCreate");
					data.GmtModify = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].GmtModify");
					data.NetExtend = _ctx.LongValue("QueryNetList.Data["+ i +"].Nets["+ j +"].NetExtend");
					data.FwdEffect = _ctx.LongValue("QueryNetList.Data["+ i +"].Nets["+ j +"].FwdEffect");
					data.NetMain = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].NetMain");

					QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense dDoSDefense = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense();

					QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_DjPolicy djPolicy = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_DjPolicy();
					djPolicy.PolicyName = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].DDoSDefense.DjPolicy.PolicyName");
					dDoSDefense.DjPolicy = djPolicy;

					QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_CleanTh cleanTh = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_CleanTh();
					cleanTh.Mbps = _ctx.IntegerValue("QueryNetList.Data["+ i +"].Nets["+ j +"].DDoSDefense.CleanTh.Mbps");
					cleanTh.Pps = _ctx.IntegerValue("QueryNetList.Data["+ i +"].Nets["+ j +"].DDoSDefense.CleanTh.Pps");
					dDoSDefense.CleanTh = cleanTh;

					QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_HoleTh holeTh = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DDoSDefense.QueryNetList_HoleTh();
					holeTh.ThreshMbps = _ctx.IntegerValue("QueryNetList.Data["+ i +"].Nets["+ j +"].DDoSDefense.HoleTh.ThreshMbps");
					dDoSDefense.HoleTh = holeTh;
					data.DDoSDefense = dDoSDefense;

					List<QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DeclaredItem> data_declared = new List<QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DeclaredItem>();
					for (int k = 0; k < _ctx.Length("QueryNetList.Data["+ i +"].Nets["+ j +"].Declared.Length"); k++) {
						QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DeclaredItem declaredItem = new QueryNetListResponse.QueryNetList_DataItem.QueryNetList_Data.QueryNetList_DeclaredItem();
						declaredItem.Region = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].Declared["+ k +"].Region");
						declaredItem.Declared = _ctx.StringValue("QueryNetList.Data["+ i +"].Nets["+ j +"].Declared["+ k +"].Declared");

						data_declared.Add(declaredItem);
					}
					data.Declared = data_declared;

					dataItem_nets.Add(data);
				}
				dataItem.Nets = dataItem_nets;

				queryNetListResponse_data.Add(dataItem);
			}
			queryNetListResponse.Data = queryNetListResponse_data;
        
			return queryNetListResponse;
        }
    }
}
