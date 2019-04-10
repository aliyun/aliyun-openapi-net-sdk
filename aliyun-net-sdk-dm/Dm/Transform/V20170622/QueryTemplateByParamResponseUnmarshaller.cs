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
    public class QueryTemplateByParamResponseUnmarshaller
    {
        public static QueryTemplateByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTemplateByParamResponse queryTemplateByParamResponse = new QueryTemplateByParamResponse();

			queryTemplateByParamResponse.HttpResponse = context.HttpResponse;
			queryTemplateByParamResponse.RequestId = context.StringValue("QueryTemplateByParam.RequestId");
			queryTemplateByParamResponse.TotalCount = context.IntegerValue("QueryTemplateByParam.TotalCount");
			queryTemplateByParamResponse.PageNumber = context.IntegerValue("QueryTemplateByParam.PageNumber");
			queryTemplateByParamResponse.PageSize = context.IntegerValue("QueryTemplateByParam.PageSize");

			List<QueryTemplateByParamResponse.QueryTemplateByParam_Template> queryTemplateByParamResponse_data = new List<QueryTemplateByParamResponse.QueryTemplateByParam_Template>();
			for (int i = 0; i < context.Length("QueryTemplateByParam.Data.Length"); i++) {
				QueryTemplateByParamResponse.QueryTemplateByParam_Template template = new QueryTemplateByParamResponse.QueryTemplateByParam_Template();
				template.TemplateId = context.StringValue("QueryTemplateByParam.Data["+ i +"].TemplateId");
				template.TemplateName = context.StringValue("QueryTemplateByParam.Data["+ i +"].TemplateName");
				template.TemplateComment = context.StringValue("QueryTemplateByParam.Data["+ i +"].TemplateComment");
				template.TemplateStatus = context.StringValue("QueryTemplateByParam.Data["+ i +"].TemplateStatus");
				template.CreateTime = context.StringValue("QueryTemplateByParam.Data["+ i +"].CreateTime");
				template.UtcCreatetime = context.LongValue("QueryTemplateByParam.Data["+ i +"].UtcCreatetime");
				template.TemplateType = context.IntegerValue("QueryTemplateByParam.Data["+ i +"].TemplateType");
				template.SmsTemplateCode = context.IntegerValue("QueryTemplateByParam.Data["+ i +"].SmsTemplateCode");
				template.Smsrejectinfo = context.IntegerValue("QueryTemplateByParam.Data["+ i +"].Smsrejectinfo");
				template.SmsStatus = context.IntegerValue("QueryTemplateByParam.Data["+ i +"].SmsStatus");

				queryTemplateByParamResponse_data.Add(template);
			}
			queryTemplateByParamResponse.Data = queryTemplateByParamResponse_data;
        
			return queryTemplateByParamResponse;
        }
    }
}
