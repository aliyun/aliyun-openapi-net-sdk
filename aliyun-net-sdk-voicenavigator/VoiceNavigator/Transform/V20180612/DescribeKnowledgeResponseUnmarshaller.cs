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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeKnowledgeResponseUnmarshaller
    {
        public static DescribeKnowledgeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeKnowledgeResponse describeKnowledgeResponse = new DescribeKnowledgeResponse();

			describeKnowledgeResponse.HttpResponse = context.HttpResponse;
			describeKnowledgeResponse.RequestId = context.StringValue("DescribeKnowledge.RequestId");
			describeKnowledgeResponse.NavigationScriptId = context.StringValue("DescribeKnowledge.NavigationScriptId");
			describeKnowledgeResponse.InstanceId = context.StringValue("DescribeKnowledge.InstanceId");
			describeKnowledgeResponse.CategoryId = context.StringValue("DescribeKnowledge.CategoryId");
			describeKnowledgeResponse.UserUtterance = context.StringValue("DescribeKnowledge.UserUtterance");
			describeKnowledgeResponse.Answer = context.StringValue("DescribeKnowledge.Answer");
			describeKnowledgeResponse.Interruptible = context.BooleanValue("DescribeKnowledge.Interruptible");

			List<string> describeKnowledgeResponse_similarUtterances = new List<string>();
			for (int i = 0; i < context.Length("DescribeKnowledge.SimilarUtterances.Length"); i++) {
				describeKnowledgeResponse_similarUtterances.Add(context.StringValue("DescribeKnowledge.SimilarUtterances["+ i +"]"));
			}
			describeKnowledgeResponse.SimilarUtterances = describeKnowledgeResponse_similarUtterances;
        
			return describeKnowledgeResponse;
        }
    }
}
