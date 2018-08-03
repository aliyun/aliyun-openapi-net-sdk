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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class IndexTagResponseUnmarshaller
    {
        public static IndexTagResponse Unmarshall(UnmarshallerContext context)
        {
			IndexTagResponse indexTagResponse = new IndexTagResponse();

			indexTagResponse.HttpResponse = context.HttpResponse;
			indexTagResponse.RequestId = context.StringValue("IndexTag.RequestId");
			indexTagResponse.SetId = context.StringValue("IndexTag.SetId");
			indexTagResponse.SuccessIndexNum = context.StringValue("IndexTag.SuccessIndexNum");

			List<IndexTagResponse.IndexTag_FailDetailsItem> indexTagResponse_failDetails = new List<IndexTagResponse.IndexTag_FailDetailsItem>();
			for (int i = 0; i < context.Length("IndexTag.FailDetails.Length"); i++) {
				IndexTagResponse.IndexTag_FailDetailsItem failDetailsItem = new IndexTagResponse.IndexTag_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("IndexTag.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("IndexTag.FailDetails["+ i +"].Reason");

				indexTagResponse_failDetails.Add(failDetailsItem);
			}
			indexTagResponse.FailDetails = indexTagResponse_failDetails;

			List<IndexTagResponse.IndexTag_SuccessDetailsItem> indexTagResponse_successDetails = new List<IndexTagResponse.IndexTag_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("IndexTag.SuccessDetails.Length"); i++) {
				IndexTagResponse.IndexTag_SuccessDetailsItem successDetailsItem = new IndexTagResponse.IndexTag_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("IndexTag.SuccessDetails["+ i +"].SrcUri");

				List<IndexTagResponse.IndexTag_SuccessDetailsItem.IndexTag_TagsItem> successDetailsItem_tags = new List<IndexTagResponse.IndexTag_SuccessDetailsItem.IndexTag_TagsItem>();
				for (int j = 0; j < context.Length("IndexTag.SuccessDetails["+ i +"].Tags.Length"); j++) {
					IndexTagResponse.IndexTag_SuccessDetailsItem.IndexTag_TagsItem tagsItem = new IndexTagResponse.IndexTag_SuccessDetailsItem.IndexTag_TagsItem();
					tagsItem.TagId = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].TagId");
					tagsItem.TagLevel = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagId = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].ParentTagId");
					tagsItem.ParentTagName = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].ParentTagName");
					tagsItem.TagScore = context.StringValue("IndexTag.SuccessDetails["+ i +"].Tags["+ j +"].TagScore");

					successDetailsItem_tags.Add(tagsItem);
				}
				successDetailsItem.Tags = successDetailsItem_tags;

				indexTagResponse_successDetails.Add(successDetailsItem);
			}
			indexTagResponse.SuccessDetails = indexTagResponse_successDetails;
        
			return indexTagResponse;
        }
    }
}