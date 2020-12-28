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
using Aliyun.Acs.nlp_automl.Model.V20191111;

namespace Aliyun.Acs.nlp_automl.Transform.V20191111
{
    public class RunContactReviewResponseUnmarshaller
    {
        public static RunContactReviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RunContactReviewResponse runContactReviewResponse = new RunContactReviewResponse();

			runContactReviewResponse.HttpResponse = _ctx.HttpResponse;
			runContactReviewResponse.RequestId = _ctx.StringValue("RunContactReview.RequestId");
			runContactReviewResponse.RawContractContent = _ctx.StringValue("RunContactReview.RawContractContent");

			RunContactReviewResponse.RunContactReview_ContactContent contactContent = new RunContactReviewResponse.RunContactReview_ContactContent();

			List<RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_ReviewResult> contactContent_reviewResults = new List<RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_ReviewResult>();
			for (int i = 0; i < _ctx.Length("RunContactReview.ContactContent.ReviewResults.Length"); i++) {
				RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_ReviewResult reviewResult = new RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_ReviewResult();
				reviewResult.RiskLevel = _ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].RiskLevel");
				reviewResult.Reason = _ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].Reason");
				reviewResult.Type = _ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].Type");
				reviewResult.ModificationSuggestion = _ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].ModificationSuggestion");

				List<string> reviewResult_value = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.ReviewResults["+ i +"].Value.Length"); j++) {
					reviewResult_value.Add(_ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].Value["+ j +"]"));
				}
				reviewResult._Value = reviewResult_value;

				List<string> reviewResult_endPosition = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.ReviewResults["+ i +"].EndPosition.Length"); j++) {
					reviewResult_endPosition.Add(_ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].EndPosition["+ j +"]"));
				}
				reviewResult.EndPosition = reviewResult_endPosition;

				List<string> reviewResult_startPosition = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.ReviewResults["+ i +"].StartPosition.Length"); j++) {
					reviewResult_startPosition.Add(_ctx.StringValue("RunContactReview.ContactContent.ReviewResults["+ i +"].StartPosition["+ j +"]"));
				}
				reviewResult.StartPosition = reviewResult_startPosition;

				contactContent_reviewResults.Add(reviewResult);
			}
			contactContent.ReviewResults = contactContent_reviewResults;

			List<RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_StructureResult> contactContent_structureResults = new List<RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_StructureResult>();
			for (int i = 0; i < _ctx.Length("RunContactReview.ContactContent.StructureResults.Length"); i++) {
				RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_StructureResult structureResult = new RunContactReviewResponse.RunContactReview_ContactContent.RunContactReview_StructureResult();
				structureResult.Name = _ctx.StringValue("RunContactReview.ContactContent.StructureResults["+ i +"].Name");
				structureResult.Type = _ctx.StringValue("RunContactReview.ContactContent.StructureResults["+ i +"].Type");

				List<string> structureResult_value1 = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.StructureResults["+ i +"].Value.Length"); j++) {
					structureResult_value1.Add(_ctx.StringValue("RunContactReview.ContactContent.StructureResults["+ i +"].Value["+ j +"]"));
				}
				structureResult._Value1 = structureResult_value1;

				List<string> structureResult_endPosition2 = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.StructureResults["+ i +"].EndPosition.Length"); j++) {
					structureResult_endPosition2.Add(_ctx.StringValue("RunContactReview.ContactContent.StructureResults["+ i +"].EndPosition["+ j +"]"));
				}
				structureResult.EndPosition2 = structureResult_endPosition2;

				List<string> structureResult_startPosition3 = new List<string>();
				for (int j = 0; j < _ctx.Length("RunContactReview.ContactContent.StructureResults["+ i +"].StartPosition.Length"); j++) {
					structureResult_startPosition3.Add(_ctx.StringValue("RunContactReview.ContactContent.StructureResults["+ i +"].StartPosition["+ j +"]"));
				}
				structureResult.StartPosition3 = structureResult_startPosition3;

				contactContent_structureResults.Add(structureResult);
			}
			contactContent.StructureResults = contactContent_structureResults;
			runContactReviewResponse.ContactContent = contactContent;
        
			return runContactReviewResponse;
        }
    }
}
