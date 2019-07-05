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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeKeywordLibResponseUnmarshaller
    {
        public static DescribeKeywordLibResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeKeywordLibResponse describeKeywordLibResponse = new DescribeKeywordLibResponse();

			describeKeywordLibResponse.HttpResponse = context.HttpResponse;
			describeKeywordLibResponse.RequestId = context.StringValue("DescribeKeywordLib.RequestId");
			describeKeywordLibResponse.TotalCount = context.IntegerValue("DescribeKeywordLib.TotalCount");

			List<DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib> describeKeywordLibResponse_keywordLibList = new List<DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib>();
			for (int i = 0; i < context.Length("DescribeKeywordLib.KeywordLibList.Length"); i++) {
				DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib keywordLib = new DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib();
				keywordLib.Id = context.IntegerValue("DescribeKeywordLib.KeywordLibList["+ i +"].Id");
				keywordLib.ModifiedTime = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ModifiedTime");
				keywordLib.Name = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Name");
				keywordLib.Code = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Code");
				keywordLib.Count = context.IntegerValue("DescribeKeywordLib.KeywordLibList["+ i +"].Count");
				keywordLib.Category = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Category");
				keywordLib.ResourceType = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ResourceType");
				keywordLib.LibType = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].LibType");
				keywordLib.Source = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Source");
				keywordLib.ServiceModule = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ServiceModule");
				keywordLib.Language = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Language");
				keywordLib.MatchMode = context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].MatchMode");
				keywordLib.Enable = context.BooleanValue("DescribeKeywordLib.KeywordLibList["+ i +"].Enable");

				List<string> keywordLib_bizTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeKeywordLib.KeywordLibList["+ i +"].BizTypes.Length"); j++) {
					keywordLib_bizTypes.Add(context.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].BizTypes["+ j +"]"));
				}
				keywordLib.BizTypes = keywordLib_bizTypes;

				describeKeywordLibResponse_keywordLibList.Add(keywordLib);
			}
			describeKeywordLibResponse.KeywordLibList = describeKeywordLibResponse_keywordLibList;
        
			return describeKeywordLibResponse;
        }
    }
}
