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
    public class DescribeCoreWordResponseUnmarshaller
    {
        public static DescribeCoreWordResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCoreWordResponse describeCoreWordResponse = new DescribeCoreWordResponse();

			describeCoreWordResponse.HttpResponse = context.HttpResponse;
			describeCoreWordResponse.RequestId = context.StringValue("DescribeCoreWord.RequestId");
			describeCoreWordResponse.CoreWordCode = context.StringValue("DescribeCoreWord.CoreWordCode");
			describeCoreWordResponse.CoreWordName = context.StringValue("DescribeCoreWord.CoreWordName");
			describeCoreWordResponse.ModifyTime = context.StringValue("DescribeCoreWord.ModifyTime");
			describeCoreWordResponse.CreateTime = context.StringValue("DescribeCoreWord.CreateTime");

			List<string> describeCoreWordResponse_synonyms = new List<string>();
			for (int i = 0; i < context.Length("DescribeCoreWord.Synonyms.Length"); i++) {
				describeCoreWordResponse_synonyms.Add(context.StringValue("DescribeCoreWord.Synonyms["+ i +"]"));
			}
			describeCoreWordResponse.Synonyms = describeCoreWordResponse_synonyms;
        
			return describeCoreWordResponse;
        }
    }
}