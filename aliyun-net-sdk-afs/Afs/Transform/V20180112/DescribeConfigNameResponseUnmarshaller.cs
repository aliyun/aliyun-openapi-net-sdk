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
using Aliyun.Acs.afs.Model.V20180112;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribeConfigNameResponseUnmarshaller
    {
        public static DescribeConfigNameResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConfigNameResponse describeConfigNameResponse = new DescribeConfigNameResponse();

			describeConfigNameResponse.HttpResponse = context.HttpResponse;
			describeConfigNameResponse.RequestId = context.StringValue("DescribeConfigName.RequestId");
			describeConfigNameResponse.HasConfig = context.BooleanValue("DescribeConfigName.HasConfig");
			describeConfigNameResponse.BizCode = context.StringValue("DescribeConfigName.BizCode");

			List<DescribeConfigNameResponse.DescribeConfigName_ConfigName> describeConfigNameResponse_configNames = new List<DescribeConfigNameResponse.DescribeConfigName_ConfigName>();
			for (int i = 0; i < context.Length("DescribeConfigName.ConfigNames.Length"); i++) {
				DescribeConfigNameResponse.DescribeConfigName_ConfigName configName = new DescribeConfigNameResponse.DescribeConfigName_ConfigName();
				configName.AliUid = context.StringValue("DescribeConfigName.ConfigNames["+ i +"].AliUid");
				configName.ConfigName = context.StringValue("DescribeConfigName.ConfigNames["+ i +"].ConfigName");
				configName.RefExtId = context.StringValue("DescribeConfigName.ConfigNames["+ i +"].RefExtId");

				describeConfigNameResponse_configNames.Add(configName);
			}
			describeConfigNameResponse.ConfigNames = describeConfigNameResponse_configNames;
        
			return describeConfigNameResponse;
        }
    }
}
