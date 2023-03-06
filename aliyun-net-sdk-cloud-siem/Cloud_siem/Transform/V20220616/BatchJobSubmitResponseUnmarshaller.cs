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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class BatchJobSubmitResponseUnmarshaller
    {
        public static BatchJobSubmitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchJobSubmitResponse batchJobSubmitResponse = new BatchJobSubmitResponse();

			batchJobSubmitResponse.HttpResponse = _ctx.HttpResponse;
			batchJobSubmitResponse.Success = _ctx.BooleanValue("BatchJobSubmit.Success");
			batchJobSubmitResponse.Code = _ctx.IntegerValue("BatchJobSubmit.Code");
			batchJobSubmitResponse.Message = _ctx.StringValue("BatchJobSubmit.Message");
			batchJobSubmitResponse.ErrCode = _ctx.StringValue("BatchJobSubmit.ErrCode");
			batchJobSubmitResponse.RequestId = _ctx.StringValue("BatchJobSubmit.RequestId");

			BatchJobSubmitResponse.BatchJobSubmit_Data data = new BatchJobSubmitResponse.BatchJobSubmit_Data();
			data.SubmitId = _ctx.StringValue("BatchJobSubmit.Data.SubmitId");
			data.TaskCount = _ctx.IntegerValue("BatchJobSubmit.Data.TaskCount");
			data.ConfigId = _ctx.StringValue("BatchJobSubmit.Data.ConfigId");

			List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem> data_configList = new List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem>();
			for (int i = 0; i < _ctx.Length("BatchJobSubmit.Data.ConfigList.Length"); i++) {
				BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem configListItem = new BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem();
				configListItem.UserId = _ctx.LongValue("BatchJobSubmit.Data.ConfigList["+ i +"].UserId");

				List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem> configListItem_productList = new List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem>();
				for (int j = 0; j < _ctx.Length("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList.Length"); j++) {
					BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem productListItem = new BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem();
					productListItem.ProductCode = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].ProductCode");

					List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem.BatchJobSubmit_LogListItem> productListItem_logList = new List<BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem.BatchJobSubmit_LogListItem>();
					for (int k = 0; k < _ctx.Length("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList.Length"); k++) {
						BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem.BatchJobSubmit_LogListItem logListItem = new BatchJobSubmitResponse.BatchJobSubmit_Data.BatchJobSubmit_ConfigListItem.BatchJobSubmit_ProductListItem.BatchJobSubmit_LogListItem();
						logListItem.ProductCode = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProductCode");
						logListItem.LogCode = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogCode");
						logListItem.RegionCode = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].RegionCode");
						logListItem.ProjectNamePattern = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProjectNamePattern");
						logListItem.LogStoreNamePattern = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogStoreNamePattern");
						logListItem.ErrorCode = _ctx.StringValue("BatchJobSubmit.Data.ConfigList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ErrorCode");

						productListItem_logList.Add(logListItem);
					}
					productListItem.LogList = productListItem_logList;

					configListItem_productList.Add(productListItem);
				}
				configListItem.ProductList = configListItem_productList;

				data_configList.Add(configListItem);
			}
			data.ConfigList = data_configList;
			batchJobSubmitResponse.Data = data;
        
			return batchJobSubmitResponse;
        }
    }
}
