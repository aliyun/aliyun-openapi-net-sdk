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
        public static DescribeKeywordLibResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeKeywordLibResponse describeKeywordLibResponse = new DescribeKeywordLibResponse();

			describeKeywordLibResponse.HttpResponse = _ctx.HttpResponse;
			describeKeywordLibResponse.RequestId = _ctx.StringValue("DescribeKeywordLib.RequestId");
			describeKeywordLibResponse.TotalCount = _ctx.IntegerValue("DescribeKeywordLib.TotalCount");

			List<DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib> describeKeywordLibResponse_keywordLibList = new List<DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib>();
			for (int i = 0; i < _ctx.Length("DescribeKeywordLib.KeywordLibList.Length"); i++) {
				DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib keywordLib = new DescribeKeywordLibResponse.DescribeKeywordLib_KeywordLib();
				keywordLib.Id = _ctx.IntegerValue("DescribeKeywordLib.KeywordLibList["+ i +"].Id");
				keywordLib.ModifiedTime = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ModifiedTime");
				keywordLib.Name = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Name");
				keywordLib.Code = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Code");
				keywordLib.Count = _ctx.IntegerValue("DescribeKeywordLib.KeywordLibList["+ i +"].Count");
				keywordLib.Category = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Category");
				keywordLib.ResourceType = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ResourceType");
				keywordLib.LibType = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].LibType");
				keywordLib.Source = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Source");
				keywordLib.ServiceModule = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].ServiceModule");
				keywordLib.Language = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].Language");
				keywordLib.MatchMode = _ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].MatchMode");
				keywordLib.Enable = _ctx.BooleanValue("DescribeKeywordLib.KeywordLibList["+ i +"].Enable");

				List<string> keywordLib_bizTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeKeywordLib.KeywordLibList["+ i +"].BizTypes.Length"); j++) {
					keywordLib_bizTypes.Add(_ctx.StringValue("DescribeKeywordLib.KeywordLibList["+ i +"].BizTypes["+ j +"]"));
				}
				keywordLib.BizTypes = keywordLib_bizTypes;

				describeKeywordLibResponse_keywordLibList.Add(keywordLib);
			}
			describeKeywordLibResponse.KeywordLibList = describeKeywordLibResponse_keywordLibList;
        
			return describeKeywordLibResponse;
        }
    }
}
