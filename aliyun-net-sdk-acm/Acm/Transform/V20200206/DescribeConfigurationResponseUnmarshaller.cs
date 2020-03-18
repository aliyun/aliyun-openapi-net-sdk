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
using Aliyun.Acs.acm.Model.V20200206;

namespace Aliyun.Acs.acm.Transform.V20200206
{
    public class DescribeConfigurationResponseUnmarshaller
    {
        public static DescribeConfigurationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConfigurationResponse describeConfigurationResponse = new DescribeConfigurationResponse();

			describeConfigurationResponse.HttpResponse = context.HttpResponse;
			describeConfigurationResponse.Code = context.StringValue("DescribeConfiguration.Code");
			describeConfigurationResponse.Message = context.StringValue("DescribeConfiguration.Message");
			describeConfigurationResponse.RequestId = context.StringValue("DescribeConfiguration.RequestId");

			DescribeConfigurationResponse.DescribeConfiguration_Configuration configuration = new DescribeConfigurationResponse.DescribeConfiguration_Configuration();
			configuration.AppName = context.StringValue("DescribeConfiguration.Configuration.AppName");
			configuration.Content = context.StringValue("DescribeConfiguration.Configuration.Content");
			configuration.DataId = context.StringValue("DescribeConfiguration.Configuration.DataId");
			configuration.Desc = context.StringValue("DescribeConfiguration.Configuration.Desc");
			configuration.Group = context.StringValue("DescribeConfiguration.Configuration.Group");
			configuration.Md5 = context.StringValue("DescribeConfiguration.Configuration.Md5");
			configuration.Tags = context.StringValue("DescribeConfiguration.Configuration.Tags");
			configuration.Type = context.StringValue("DescribeConfiguration.Configuration.Type");
			describeConfigurationResponse.Configuration = configuration;
        
			return describeConfigurationResponse;
        }
    }
}
