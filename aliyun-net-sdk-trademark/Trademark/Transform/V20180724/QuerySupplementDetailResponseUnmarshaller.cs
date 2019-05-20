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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QuerySupplementDetailResponseUnmarshaller
    {
        public static QuerySupplementDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySupplementDetailResponse querySupplementDetailResponse = new QuerySupplementDetailResponse();

			querySupplementDetailResponse.HttpResponse = context.HttpResponse;
			querySupplementDetailResponse.RequestId = context.StringValue("QuerySupplementDetail.RequestId");
			querySupplementDetailResponse.Id = context.LongValue("QuerySupplementDetail.Id");
			querySupplementDetailResponse.SerialNumber = context.StringValue("QuerySupplementDetail.SerialNumber");
			querySupplementDetailResponse.Type = context.IntegerValue("QuerySupplementDetail.Type");
			querySupplementDetailResponse.Status = context.IntegerValue("QuerySupplementDetail.Status");
			querySupplementDetailResponse.TmNumber = context.StringValue("QuerySupplementDetail.TmNumber");
			querySupplementDetailResponse.SendTime = context.LongValue("QuerySupplementDetail.SendTime");
			querySupplementDetailResponse.AcceptTime = context.LongValue("QuerySupplementDetail.AcceptTime");
			querySupplementDetailResponse.SbjDeadTime = context.LongValue("QuerySupplementDetail.SbjDeadTime");
			querySupplementDetailResponse.AcceptDeadTime = context.LongValue("QuerySupplementDetail.AcceptDeadTime");
			querySupplementDetailResponse.OperateTime = context.LongValue("QuerySupplementDetail.OperateTime");
			querySupplementDetailResponse.UploadFileTemplateUrl = context.StringValue("QuerySupplementDetail.UploadFileTemplateUrl");
			querySupplementDetailResponse.Content = context.StringValue("QuerySupplementDetail.Content");

			List<string> querySupplementDetailResponse_fileTemplateUrls = new List<string>();
			for (int i = 0; i < context.Length("QuerySupplementDetail.FileTemplateUrls.Length"); i++) {
				querySupplementDetailResponse_fileTemplateUrls.Add(context.StringValue("QuerySupplementDetail.FileTemplateUrls["+ i +"]"));
			}
			querySupplementDetailResponse.FileTemplateUrls = querySupplementDetailResponse_fileTemplateUrls;
        
			return querySupplementDetailResponse;
        }
    }
}
