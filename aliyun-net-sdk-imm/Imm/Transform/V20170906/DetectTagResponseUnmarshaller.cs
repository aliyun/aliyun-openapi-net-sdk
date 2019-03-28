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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectTagResponseUnmarshaller
    {
        public static DetectTagResponse Unmarshall(UnmarshallerContext context)
        {
			DetectTagResponse detectTagResponse = new DetectTagResponse();

			detectTagResponse.HttpResponse = context.HttpResponse;
			detectTagResponse.RequestId = context.StringValue("DetectTag.RequestId");
			detectTagResponse.SuccessNum = context.StringValue("DetectTag.SuccessNum");

			List<DetectTagResponse.DetectTag_SuccessDetailsItem> detectTagResponse_successDetails = new List<DetectTagResponse.DetectTag_SuccessDetailsItem>();
			for (int i = 0; i < context.Length("DetectTag.SuccessDetails.Length"); i++) {
				DetectTagResponse.DetectTag_SuccessDetailsItem successDetailsItem = new DetectTagResponse.DetectTag_SuccessDetailsItem();
				successDetailsItem.SrcUri = context.StringValue("DetectTag.SuccessDetails["+ i +"].SrcUri");

				List<DetectTagResponse.DetectTag_SuccessDetailsItem.DetectTag_TagsItem> successDetailsItem_tags = new List<DetectTagResponse.DetectTag_SuccessDetailsItem.DetectTag_TagsItem>();
				for (int j = 0; j < context.Length("DetectTag.SuccessDetails["+ i +"].Tags.Length"); j++) {
					DetectTagResponse.DetectTag_SuccessDetailsItem.DetectTag_TagsItem tagsItem = new DetectTagResponse.DetectTag_SuccessDetailsItem.DetectTag_TagsItem();
					tagsItem.TagId = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].TagId");
					tagsItem.TagLevel = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].TagLevel");
					tagsItem.TagName = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].TagName");
					tagsItem.ParentTagId = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].ParentTagId");
					tagsItem.ParentTagName = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].ParentTagName");
					tagsItem.TagScore = context.StringValue("DetectTag.SuccessDetails["+ i +"].Tags["+ j +"].TagScore");

					successDetailsItem_tags.Add(tagsItem);
				}
				successDetailsItem.Tags = successDetailsItem_tags;

				detectTagResponse_successDetails.Add(successDetailsItem);
			}
			detectTagResponse.SuccessDetails = detectTagResponse_successDetails;

			List<DetectTagResponse.DetectTag_FailDetailsItem> detectTagResponse_failDetails = new List<DetectTagResponse.DetectTag_FailDetailsItem>();
			for (int i = 0; i < context.Length("DetectTag.FailDetails.Length"); i++) {
				DetectTagResponse.DetectTag_FailDetailsItem failDetailsItem = new DetectTagResponse.DetectTag_FailDetailsItem();
				failDetailsItem.SrcUri = context.StringValue("DetectTag.FailDetails["+ i +"].SrcUri");
				failDetailsItem.Reason = context.StringValue("DetectTag.FailDetails["+ i +"].Reason");

				detectTagResponse_failDetails.Add(failDetailsItem);
			}
			detectTagResponse.FailDetails = detectTagResponse_failDetails;
        
			return detectTagResponse;
        }
    }
}
