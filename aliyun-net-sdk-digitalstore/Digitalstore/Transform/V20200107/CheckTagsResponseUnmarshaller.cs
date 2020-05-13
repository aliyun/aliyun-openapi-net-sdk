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
				checkTagResultBiz.BeValid = context.BooleanValue("CheckTags.CheckResult["+ i +"].BeValid");
				checkTagResultBiz.BeBound = context.BooleanValue("CheckTags.CheckResult["+ i +"].BeBound");
				checkTagResultBiz.BeOrderTag = context.BooleanValue("CheckTags.CheckResult["+ i +"].BeOrderTag");
				checkTagResultBiz.BeBoxing = context.BooleanValue("CheckTags.CheckResult["+ i +"].BeBoxing");
				checkTagResultBiz.TagPositionType = context.StringValue("CheckTags.CheckResult["+ i +"].TagPositionType");
				checkTagResultBiz.StyleId = context.StringValue("CheckTags.CheckResult["+ i +"].StyleId");
				checkTagResultBiz.StyleCode = context.StringValue("CheckTags.CheckResult["+ i +"].StyleCode");
				checkTagResultBiz.StyleName = context.StringValue("CheckTags.CheckResult["+ i +"].StyleName");
				checkTagResultBiz.SKUId = context.StringValue("CheckTags.CheckResult["+ i +"].SKUId");
				checkTagResultBiz.SKUName = context.StringValue("CheckTags.CheckResult["+ i +"].SKUName");
				checkTagResultBiz.ColorCode = context.StringValue("CheckTags.CheckResult["+ i +"].ColorCode");
				checkTagResultBiz.ColorName = context.StringValue("CheckTags.CheckResult["+ i +"].ColorName");
				checkTagResultBiz.SizeCode = context.StringValue("CheckTags.CheckResult["+ i +"].SizeCode");
				checkTagResultBiz.SizeName = context.StringValue("CheckTags.CheckResult["+ i +"].SizeName");
				checkTagResultBiz.TagPositionId = context.StringValue("CheckTags.CheckResult["+ i +"].TagPositionId");
				checkTagResultBiz.BrandCode = context.StringValue("CheckTags.CheckResult["+ i +"].BrandCode");
				checkTagResultBiz.BrandName = context.StringValue("CheckTags.CheckResult["+ i +"].BrandName");
				checkTagResultBiz.CaseId = context.StringValue("CheckTags.CheckResult["+ i +"].CaseId");
				checkTagResultBiz.SizeId = context.StringValue("CheckTags.CheckResult["+ i +"].SizeId");
				checkTagResultBiz.ColorId = context.StringValue("CheckTags.CheckResult["+ i +"].ColorId");
				checkTagResultBiz.CaseCode = context.StringValue("CheckTags.CheckResult["+ i +"].CaseCode");
				checkTagResultBiz.BrandId = context.StringValue("CheckTags.CheckResult["+ i +"].BrandId");

				checkTagsResponse_checkResult.Add(checkTagResultBiz);
			}
			checkTagsResponse.CheckResult = checkTagsResponse_checkResult;
        
			return checkTagsResponse;
        }
    }
}
