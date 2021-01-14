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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListDeviceRelationResponseUnmarshaller
    {
        public static ListDeviceRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceRelationResponse listDeviceRelationResponse = new ListDeviceRelationResponse();

			listDeviceRelationResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceRelationResponse.RequestId = _ctx.StringValue("ListDeviceRelation.RequestId");
			listDeviceRelationResponse.Code = _ctx.StringValue("ListDeviceRelation.Code");
			listDeviceRelationResponse.Message = _ctx.StringValue("ListDeviceRelation.Message");

			List<ListDeviceRelationResponse.ListDeviceRelation_DataItem> listDeviceRelationResponse_data = new List<ListDeviceRelationResponse.ListDeviceRelation_DataItem>();
			for (int i = 0; i < _ctx.Length("ListDeviceRelation.Data.Length"); i++) {
				ListDeviceRelationResponse.ListDeviceRelation_DataItem dataItem = new ListDeviceRelationResponse.ListDeviceRelation_DataItem();
				dataItem.CorpId = _ctx.StringValue("ListDeviceRelation.Data["+ i +"].CorpId");

				listDeviceRelationResponse_data.Add(dataItem);
			}
			listDeviceRelationResponse.Data = listDeviceRelationResponse_data;
        
			return listDeviceRelationResponse;
        }
    }
}
