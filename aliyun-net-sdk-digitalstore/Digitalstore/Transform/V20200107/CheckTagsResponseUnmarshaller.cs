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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class CheckTagsResponseUnmarshaller
    {
        public static CheckTagsResponse Unmarshall(UnmarshallerContext context)
        {
			CheckTagsResponse checkTagsResponse = new CheckTagsResponse();

			checkTagsResponse.HttpResponse = context.HttpResponse;
			checkTagsResponse.RequestId = context.StringValue("CheckTags.RequestId");
			checkTagsResponse.Success = context.BooleanValue("CheckTags.Success");

			List<CheckTagsResponse.CheckTags_CheckTagResultBiz> checkTagsResponse_checkResult = new List<CheckTagsResponse.CheckTags_CheckTagResultBiz>();
			for (int i = 0; i < context.Length("CheckTags.CheckResult.Length"); i++) {
				CheckTagsResponse.CheckTags_CheckTagResultBiz checkTagResultBiz = new CheckTagsResponse.CheckTags_CheckTagResultBiz();
				checkTagResultBiz.TagValue = context.StringValue("CheckTags.CheckResult["+ i +"].TagValue");
				checkTagResultBiz.TagId = context.StringValue("CheckTags.CheckResult["+ i +"].TagId");
				checkTagResultBiz.Barcode = context.StringValue("CheckTags.CheckResult["+ i +"].Barcode");
				checkTagResultBiz.IsExist = context.IntegerValue("CheckTags.CheckResult["+ i +"].IsExist");

				checkTagsResponse_checkResult.Add(checkTagResultBiz);
			}
			checkTagsResponse.CheckResult = checkTagsResponse_checkResult;
        
			return checkTagsResponse;
        }
    }
}
