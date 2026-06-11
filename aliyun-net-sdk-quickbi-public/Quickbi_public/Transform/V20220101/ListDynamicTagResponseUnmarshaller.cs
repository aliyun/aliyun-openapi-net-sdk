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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListDynamicTagResponseUnmarshaller
    {
        public static ListDynamicTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDynamicTagResponse listDynamicTagResponse = new ListDynamicTagResponse();

			listDynamicTagResponse.HttpResponse = _ctx.HttpResponse;
			listDynamicTagResponse.RequestId = _ctx.StringValue("ListDynamicTag.RequestId");
			listDynamicTagResponse.Success = _ctx.BooleanValue("ListDynamicTag.Success");

			List<ListDynamicTagResponse.ListDynamicTag_Data> listDynamicTagResponse_result = new List<ListDynamicTagResponse.ListDynamicTag_Data>();
			for (int i = 0; i < _ctx.Length("ListDynamicTag.Result.Length"); i++) {
				ListDynamicTagResponse.ListDynamicTag_Data data = new ListDynamicTagResponse.ListDynamicTag_Data();
				data.OrganizationId = _ctx.StringValue("ListDynamicTag.Result["+ i +"].OrganizationId");
				data.ConfigId = _ctx.StringValue("ListDynamicTag.Result["+ i +"].ConfigId");
				data.ConfigName = _ctx.StringValue("ListDynamicTag.Result["+ i +"].ConfigName");
				data.DsId = _ctx.StringValue("ListDynamicTag.Result["+ i +"].DsId");
				data.TableName = _ctx.StringValue("ListDynamicTag.Result["+ i +"].TableName");
				data.ColumnName = _ctx.StringValue("ListDynamicTag.Result["+ i +"].ColumnName");
				data.RelatedAttribute = _ctx.IntegerValue("ListDynamicTag.Result["+ i +"].RelatedAttribute");

				listDynamicTagResponse_result.Add(data);
			}
			listDynamicTagResponse.Result = listDynamicTagResponse_result;
        
			return listDynamicTagResponse;
        }
    }
}
