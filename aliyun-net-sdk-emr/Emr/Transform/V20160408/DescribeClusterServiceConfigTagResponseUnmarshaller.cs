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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterServiceConfigTagResponseUnmarshaller
    {
        public static DescribeClusterServiceConfigTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterServiceConfigTagResponse describeClusterServiceConfigTagResponse = new DescribeClusterServiceConfigTagResponse();

			describeClusterServiceConfigTagResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterServiceConfigTagResponse.RequestId = _ctx.StringValue("DescribeClusterServiceConfigTag.RequestId");

			List<DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag> describeClusterServiceConfigTagResponse_configTagList = new List<DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag>();
			for (int i = 0; i < _ctx.Length("DescribeClusterServiceConfigTag.ConfigTagList.Length"); i++) {
				DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag configTag = new DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag();
				configTag.Tag = _ctx.StringValue("DescribeClusterServiceConfigTag.ConfigTagList["+ i +"].Tag");
				configTag.TagDesc = _ctx.StringValue("DescribeClusterServiceConfigTag.ConfigTagList["+ i +"].TagDesc");

				List<DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag.DescribeClusterServiceConfigTag__Value> configTag_valueList = new List<DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag.DescribeClusterServiceConfigTag__Value>();
				for (int j = 0; j < _ctx.Length("DescribeClusterServiceConfigTag.ConfigTagList["+ i +"].ValueList.Length"); j++) {
					DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag.DescribeClusterServiceConfigTag__Value _value = new DescribeClusterServiceConfigTagResponse.DescribeClusterServiceConfigTag_ConfigTag.DescribeClusterServiceConfigTag__Value();
					_value._Value = _ctx.StringValue("DescribeClusterServiceConfigTag.ConfigTagList["+ i +"].ValueList["+ j +"].Value");
					_value.ValueDesc = _ctx.StringValue("DescribeClusterServiceConfigTag.ConfigTagList["+ i +"].ValueList["+ j +"].ValueDesc");

					configTag_valueList.Add(_value);
				}
				configTag.ValueList = configTag_valueList;

				describeClusterServiceConfigTagResponse_configTagList.Add(configTag);
			}
			describeClusterServiceConfigTagResponse.ConfigTagList = describeClusterServiceConfigTagResponse_configTagList;
        
			return describeClusterServiceConfigTagResponse;
        }
    }
}
