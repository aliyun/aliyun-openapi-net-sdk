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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryTagByParamResponseUnmarshaller
    {
        public static QueryTagByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTagByParamResponse queryTagByParamResponse = new QueryTagByParamResponse();

			queryTagByParamResponse.HttpResponse = context.HttpResponse;
			queryTagByParamResponse.RequestId = context.StringValue("QueryTagByParam.RequestId");
			queryTagByParamResponse.TotalCount = context.IntegerValue("QueryTagByParam.TotalCount");
			queryTagByParamResponse.PageNumber = context.IntegerValue("QueryTagByParam.PageNumber");
			queryTagByParamResponse.PageSize = context.IntegerValue("QueryTagByParam.PageSize");

			List<QueryTagByParamResponse.QueryTagByParam_Tag> queryTagByParamResponse_data = new List<QueryTagByParamResponse.QueryTagByParam_Tag>();
			for (int i = 0; i < context.Length("QueryTagByParam.Data.Length"); i++) {
				QueryTagByParamResponse.QueryTagByParam_Tag tag = new QueryTagByParamResponse.QueryTagByParam_Tag();
				tag.TagId = context.StringValue("QueryTagByParam.Data["+ i +"].TagId");
				tag.TagName = context.StringValue("QueryTagByParam.Data["+ i +"].TagName");

				queryTagByParamResponse_data.Add(tag);
			}
			queryTagByParamResponse.Data = queryTagByParamResponse_data;
        
			return queryTagByParamResponse;
        }
    }
}
