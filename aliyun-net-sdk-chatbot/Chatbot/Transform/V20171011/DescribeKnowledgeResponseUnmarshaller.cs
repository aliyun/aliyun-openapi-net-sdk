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
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class DescribeKnowledgeResponseUnmarshaller
    {
        public static DescribeKnowledgeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeKnowledgeResponse describeKnowledgeResponse = new DescribeKnowledgeResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeKnowledge.RequestId"),
                EndDate = context.StringValue("DescribeKnowledge.EndDate"),
                CreateUserName = context.StringValue("DescribeKnowledge.CreateUserName"),
                KnowledgeTitle = context.StringValue("DescribeKnowledge.KnowledgeTitle"),
                Version = context.IntegerValue("DescribeKnowledge.Version"),
                KnowledgeId = context.LongValue("DescribeKnowledge.KnowledgeId"),
                ModifyUserName = context.StringValue("DescribeKnowledge.ModifyUserName"),
                ModifyTime = context.StringValue("DescribeKnowledge.ModifyTime"),
                CreateTime = context.StringValue("DescribeKnowledge.CreateTime"),
                KnowledgeType = context.IntegerValue("DescribeKnowledge.KnowledgeType"),
                CategoryId = context.LongValue("DescribeKnowledge.CategoryId"),
                StartDate = context.StringValue("DescribeKnowledge.StartDate"),
                KnowledgeStatus = context.IntegerValue("DescribeKnowledge.KnowledgeStatus")
            };

            List<string> describeKnowledgeResponse_keyWords = new List<string>();
			for (int i = 0; i < context.Length("DescribeKnowledge.KeyWords.Length"); i++) {
				describeKnowledgeResponse_keyWords.Add(context.StringValue("DescribeKnowledge.KeyWords["+ i +"]"));
			}
			describeKnowledgeResponse.KeyWords = describeKnowledgeResponse_keyWords;

			List<string> describeKnowledgeResponse_coreWords = new List<string>();
			for (int i = 0; i < context.Length("DescribeKnowledge.CoreWords.Length"); i++) {
				describeKnowledgeResponse_coreWords.Add(context.StringValue("DescribeKnowledge.CoreWords["+ i +"]"));
			}
			describeKnowledgeResponse.CoreWords = describeKnowledgeResponse_coreWords;

			List<DescribeKnowledgeResponse.DescribeKnowledge_Outline> describeKnowledgeResponse_outlines = new List<DescribeKnowledgeResponse.DescribeKnowledge_Outline>();
			for (int i = 0; i < context.Length("DescribeKnowledge.Outlines.Length"); i++) {
                DescribeKnowledgeResponse.DescribeKnowledge_Outline outline = new DescribeKnowledgeResponse.DescribeKnowledge_Outline
                {
                    KnowledgeId = context.LongValue("DescribeKnowledge.Outlines[" + i + "].KnowledgeId"),
                    Title = context.StringValue("DescribeKnowledge.Outlines[" + i + "].Title"),
                    OutlineId = context.LongValue("DescribeKnowledge.Outlines[" + i + "].OutlineId")
                };

                describeKnowledgeResponse_outlines.Add(outline);
			}
			describeKnowledgeResponse.Outlines = describeKnowledgeResponse_outlines;

			List<DescribeKnowledgeResponse.DescribeKnowledge_SimQuestion> describeKnowledgeResponse_simQuestions = new List<DescribeKnowledgeResponse.DescribeKnowledge_SimQuestion>();
			for (int i = 0; i < context.Length("DescribeKnowledge.SimQuestions.Length"); i++) {
                DescribeKnowledgeResponse.DescribeKnowledge_SimQuestion simQuestion = new DescribeKnowledgeResponse.DescribeKnowledge_SimQuestion
                {
                    ModifyTime = context.StringValue("DescribeKnowledge.SimQuestions[" + i + "].ModifyTime"),
                    CreateTime = context.StringValue("DescribeKnowledge.SimQuestions[" + i + "].CreateTime"),
                    SimQuestionId = context.LongValue("DescribeKnowledge.SimQuestions[" + i + "].SimQuestionId"),
                    Title = context.StringValue("DescribeKnowledge.SimQuestions[" + i + "].Title")
                };

                describeKnowledgeResponse_simQuestions.Add(simQuestion);
			}
			describeKnowledgeResponse.SimQuestions = describeKnowledgeResponse_simQuestions;

			List<DescribeKnowledgeResponse.DescribeKnowledge_Solution> describeKnowledgeResponse_solutions = new List<DescribeKnowledgeResponse.DescribeKnowledge_Solution>();
			for (int i = 0; i < context.Length("DescribeKnowledge.Solutions.Length"); i++) {
                DescribeKnowledgeResponse.DescribeKnowledge_Solution solution = new DescribeKnowledgeResponse.DescribeKnowledge_Solution
                {
                    Summary = context.StringValue("DescribeKnowledge.Solutions[" + i + "].Summary"),
                    ModifyTime = context.StringValue("DescribeKnowledge.Solutions[" + i + "].ModifyTime"),
                    CreateTime = context.StringValue("DescribeKnowledge.Solutions[" + i + "].CreateTime"),
                    SolutionId = context.LongValue("DescribeKnowledge.Solutions[" + i + "].SolutionId"),
                    Content = context.StringValue("DescribeKnowledge.Solutions[" + i + "].Content"),
                    PlainText = context.StringValue("DescribeKnowledge.Solutions[" + i + "].PlainText")
                };

                List<string> solution_perspectiveIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeKnowledge.Solutions["+ i +"].PerspectiveIds.Length"); j++) {
					solution_perspectiveIds.Add(context.StringValue("DescribeKnowledge.Solutions["+ i +"].PerspectiveIds["+ j +"]"));
				}
				solution.PerspectiveIds = solution_perspectiveIds;

				describeKnowledgeResponse_solutions.Add(solution);
			}
			describeKnowledgeResponse.Solutions = describeKnowledgeResponse_solutions;
        
			return describeKnowledgeResponse;
        }
    }
}