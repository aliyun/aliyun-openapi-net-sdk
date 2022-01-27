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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeQueryProcessorResponseUnmarshaller
    {
        public static DescribeQueryProcessorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeQueryProcessorResponse describeQueryProcessorResponse = new DescribeQueryProcessorResponse();

			describeQueryProcessorResponse.HttpResponse = _ctx.HttpResponse;
			describeQueryProcessorResponse.RequestId = _ctx.StringValue("DescribeQueryProcessor.requestId");

			DescribeQueryProcessorResponse.DescribeQueryProcessor_Result result = new DescribeQueryProcessorResponse.DescribeQueryProcessor_Result();
			result.Name = _ctx.StringValue("DescribeQueryProcessor.Result.name");
			result.Active = _ctx.BooleanValue("DescribeQueryProcessor.Result.active");
			result.Domain = _ctx.StringValue("DescribeQueryProcessor.Result.domain");
			result.Created = _ctx.IntegerValue("DescribeQueryProcessor.Result.created");
			result.Updated = _ctx.IntegerValue("DescribeQueryProcessor.Result.updated");

			List<string> result_indexes = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeQueryProcessor.Result.Indexes.Length"); i++) {
				result_indexes.Add(_ctx.StringValue("DescribeQueryProcessor.Result.Indexes["+ i +"]"));
			}
			result.Indexes = result_indexes;

			List<Dictionary<string, string>> result_processors = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("DescribeQueryProcessor.Result.Processors.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "DescribeQueryProcessor.Result.Processors["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					result_processors.Add(tmp);
				}
			}
			result.Processors = result_processors;
			describeQueryProcessorResponse.Result = result;
        
			return describeQueryProcessorResponse;
        }
    }
}
