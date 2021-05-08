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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListNodeInputOrOutputResponseUnmarshaller
    {
        public static ListNodeInputOrOutputResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeInputOrOutputResponse listNodeInputOrOutputResponse = new ListNodeInputOrOutputResponse();

			listNodeInputOrOutputResponse.HttpResponse = _ctx.HttpResponse;
			listNodeInputOrOutputResponse.Success = _ctx.BooleanValue("ListNodeInputOrOutput.Success");
			listNodeInputOrOutputResponse.ErrorCode = _ctx.StringValue("ListNodeInputOrOutput.ErrorCode");
			listNodeInputOrOutputResponse.ErrorMessage = _ctx.StringValue("ListNodeInputOrOutput.ErrorMessage");
			listNodeInputOrOutputResponse.HttpStatusCode = _ctx.IntegerValue("ListNodeInputOrOutput.HttpStatusCode");
			listNodeInputOrOutputResponse.RequestId = _ctx.StringValue("ListNodeInputOrOutput.RequestId");

			List<ListNodeInputOrOutputResponse.ListNodeInputOrOutput_DataItem> listNodeInputOrOutputResponse_data = new List<ListNodeInputOrOutputResponse.ListNodeInputOrOutput_DataItem>();
			for (int i = 0; i < _ctx.Length("ListNodeInputOrOutput.Data.Length"); i++) {
				ListNodeInputOrOutputResponse.ListNodeInputOrOutput_DataItem dataItem = new ListNodeInputOrOutputResponse.ListNodeInputOrOutput_DataItem();
				dataItem.TableName = _ctx.StringValue("ListNodeInputOrOutput.Data["+ i +"].TableName");
				dataItem.Data = _ctx.StringValue("ListNodeInputOrOutput.Data["+ i +"].Data");
				dataItem.NodeId = _ctx.LongValue("ListNodeInputOrOutput.Data["+ i +"].NodeId");

				listNodeInputOrOutputResponse_data.Add(dataItem);
			}
			listNodeInputOrOutputResponse.Data = listNodeInputOrOutputResponse_data;
        
			return listNodeInputOrOutputResponse;
        }
    }
}
