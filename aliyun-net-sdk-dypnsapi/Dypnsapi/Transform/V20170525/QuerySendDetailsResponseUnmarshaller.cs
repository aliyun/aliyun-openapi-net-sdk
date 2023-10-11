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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class QuerySendDetailsResponseUnmarshaller
    {
        public static QuerySendDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySendDetailsResponse querySendDetailsResponse = new QuerySendDetailsResponse();

			querySendDetailsResponse.HttpResponse = _ctx.HttpResponse;
			querySendDetailsResponse.AccessDeniedDetail = _ctx.StringValue("QuerySendDetails.AccessDeniedDetail");
			querySendDetailsResponse.TotalCount = _ctx.LongValue("QuerySendDetails.TotalCount");
			querySendDetailsResponse.Message = _ctx.StringValue("QuerySendDetails.Message");
			querySendDetailsResponse.Code = _ctx.StringValue("QuerySendDetails.Code");
			querySendDetailsResponse.Success = _ctx.BooleanValue("QuerySendDetails.Success");

			List<QuerySendDetailsResponse.QuerySendDetails_ModelItem> querySendDetailsResponse_model = new List<QuerySendDetailsResponse.QuerySendDetails_ModelItem>();
			for (int i = 0; i < _ctx.Length("QuerySendDetails.Model.Length"); i++) {
				QuerySendDetailsResponse.QuerySendDetails_ModelItem modelItem = new QuerySendDetailsResponse.QuerySendDetails_ModelItem();
				modelItem.TemplateCode = _ctx.StringValue("QuerySendDetails.Model["+ i +"].TemplateCode");
				modelItem.ReceiveDate = _ctx.StringValue("QuerySendDetails.Model["+ i +"].ReceiveDate");
				modelItem.PhoneNum = _ctx.StringValue("QuerySendDetails.Model["+ i +"].PhoneNum");
				modelItem.Content = _ctx.StringValue("QuerySendDetails.Model["+ i +"].Content");
				modelItem.SendStatus = _ctx.LongValue("QuerySendDetails.Model["+ i +"].SendStatus");
				modelItem.OutId = _ctx.StringValue("QuerySendDetails.Model["+ i +"].OutId");
				modelItem.SendDate = _ctx.StringValue("QuerySendDetails.Model["+ i +"].SendDate");
				modelItem.ErrCode = _ctx.StringValue("QuerySendDetails.Model["+ i +"].ErrCode");

				querySendDetailsResponse_model.Add(modelItem);
			}
			querySendDetailsResponse.Model = querySendDetailsResponse_model;
        
			return querySendDetailsResponse;
        }
    }
}
