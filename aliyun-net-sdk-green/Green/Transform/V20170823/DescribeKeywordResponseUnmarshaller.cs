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
    public class DescribeKeywordResponseUnmarshaller
    {
        public static DescribeKeywordResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeKeywordResponse describeKeywordResponse = new DescribeKeywordResponse();

			describeKeywordResponse.HttpResponse = context.HttpResponse;
			describeKeywordResponse.RequestId = context.StringValue("DescribeKeyword.RequestId");
			describeKeywordResponse.TotalCount = context.IntegerValue("DescribeKeyword.TotalCount");
			describeKeywordResponse.PageSize = context.IntegerValue("DescribeKeyword.PageSize");
			describeKeywordResponse.CurrentPage = context.IntegerValue("DescribeKeyword.CurrentPage");

			List<DescribeKeywordResponse.DescribeKeyword_Keyword> describeKeywordResponse_keywordList = new List<DescribeKeywordResponse.DescribeKeyword_Keyword>();
			for (int i = 0; i < context.Length("DescribeKeyword.KeywordList.Length"); i++) {
				DescribeKeywordResponse.DescribeKeyword_Keyword keyword = new DescribeKeywordResponse.DescribeKeyword_Keyword();
				keyword.Id = context.IntegerValue("DescribeKeyword.KeywordList["+ i +"].Id");
				keyword.CreateTime = context.StringValue("DescribeKeyword.KeywordList["+ i +"].CreateTime");
				keyword.Keyword = context.StringValue("DescribeKeyword.KeywordList["+ i +"].Keyword");
				keyword.HitCount = context.IntegerValue("DescribeKeyword.KeywordList["+ i +"].HitCount");

				describeKeywordResponse_keywordList.Add(keyword);
			}
			describeKeywordResponse.KeywordList = describeKeywordResponse_keywordList;
        
			return describeKeywordResponse;
        }
    }
}
