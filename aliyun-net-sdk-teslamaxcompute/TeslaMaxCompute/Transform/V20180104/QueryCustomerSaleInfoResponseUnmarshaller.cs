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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaMaxCompute.Model.V20180104;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20180104
{
    public class QueryCustomerSaleInfoResponseUnmarshaller
    {
        public static QueryCustomerSaleInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCustomerSaleInfoResponse queryCustomerSaleInfoResponse = new QueryCustomerSaleInfoResponse();

			queryCustomerSaleInfoResponse.HttpResponse = context.HttpResponse;
			queryCustomerSaleInfoResponse.Code = context.IntegerValue("QueryCustomerSaleInfo.Code");
			queryCustomerSaleInfoResponse.Message = context.StringValue("QueryCustomerSaleInfo.Message");
			queryCustomerSaleInfoResponse.RequestId = context.StringValue("QueryCustomerSaleInfo.RequestId");

			QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data data = new QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data();
			data.LastUpdate = context.StringValue("QueryCustomerSaleInfo.Data.LastUpdate");

			List<QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster> data_clusters = new List<QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster>();
			for (int i = 0; i < context.Length("QueryCustomerSaleInfo.Data.Clusters.Length"); i++) {
				QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster cluster = new QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster();
				cluster.Cluster = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].Cluster");
				cluster.Region = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].Region");
				cluster.MachineRoom = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].MachineRoom");

				List<QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster.QueryCustomerSaleInfo_SaleInfo> cluster_saleInfos = new List<QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster.QueryCustomerSaleInfo_SaleInfo>();
				for (int j = 0; j < context.Length("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos.Length"); j++) {
					QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster.QueryCustomerSaleInfo_SaleInfo saleInfo = new QueryCustomerSaleInfoResponse.QueryCustomerSaleInfo_Data.QueryCustomerSaleInfo_Cluster.QueryCustomerSaleInfo_SaleInfo();
					saleInfo.SaleMode = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].SaleMode");
					saleInfo.Uid = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].Uid");
					saleInfo.Mem = context.LongValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].Mem");
					saleInfo.Cpu = context.LongValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].Cpu");
					saleInfo.BizCategory = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].BizCategory");
					saleInfo.Owner = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].Owner");
					saleInfo.QueryDate = context.StringValue("QueryCustomerSaleInfo.Data.Clusters["+ i +"].SaleInfos["+ j +"].QueryDate");

					cluster_saleInfos.Add(saleInfo);
				}
				cluster.SaleInfos = cluster_saleInfos;

				data_clusters.Add(cluster);
			}
			data.Clusters = data_clusters;
			queryCustomerSaleInfoResponse.Data = data;
        
			return queryCustomerSaleInfoResponse;
        }
    }
}