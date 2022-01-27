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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListDistributedProductResponseUnmarshaller
    {
        public static ListDistributedProductResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDistributedProductResponse listDistributedProductResponse = new ListDistributedProductResponse();

			listDistributedProductResponse.HttpResponse = _ctx.HttpResponse;
			listDistributedProductResponse.RequestId = _ctx.StringValue("ListDistributedProduct.RequestId");
			listDistributedProductResponse.Success = _ctx.BooleanValue("ListDistributedProduct.Success");
			listDistributedProductResponse.Code = _ctx.StringValue("ListDistributedProduct.Code");
			listDistributedProductResponse.ErrorMessage = _ctx.StringValue("ListDistributedProduct.ErrorMessage");

			ListDistributedProductResponse.ListDistributedProduct_Data data = new ListDistributedProductResponse.ListDistributedProduct_Data();
			data.Total = _ctx.IntegerValue("ListDistributedProduct.Data.Total");

			List<ListDistributedProductResponse.ListDistributedProduct_Data.ListDistributedProduct_Items> data_info = new List<ListDistributedProductResponse.ListDistributedProduct_Data.ListDistributedProduct_Items>();
			for (int i = 0; i < _ctx.Length("ListDistributedProduct.Data.Info.Length"); i++) {
				ListDistributedProductResponse.ListDistributedProduct_Data.ListDistributedProduct_Items items = new ListDistributedProductResponse.ListDistributedProduct_Data.ListDistributedProduct_Items();
				items.SourceUid = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].SourceUid");
				items.TargetUid = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].TargetUid");
				items.ProductKey = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].ProductKey");
				items.SourceInstanceId = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].SourceInstanceId");
				items.TargetInstanceId = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].TargetInstanceId");
				items.GmtCreate = _ctx.IntegerValue("ListDistributedProduct.Data.Info["+ i +"].GmtCreate");
				items.TargetAliyunId = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].TargetAliyunId");
				items.SourceRegion = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].SourceRegion");
				items.TargetRegion = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].TargetRegion");
				items.SourceInstanceName = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].SourceInstanceName");
				items.TargetInstanceName = _ctx.StringValue("ListDistributedProduct.Data.Info["+ i +"].TargetInstanceName");

				data_info.Add(items);
			}
			data.Info = data_info;
			listDistributedProductResponse.Data = data;
        
			return listDistributedProductResponse;
        }
    }
}
