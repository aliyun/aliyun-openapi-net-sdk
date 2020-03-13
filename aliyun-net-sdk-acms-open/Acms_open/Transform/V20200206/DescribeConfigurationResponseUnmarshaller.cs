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
using Aliyun.Acs.acms_open.Model.V20200206;

namespace Aliyun.Acs.acms_open.Transform.V20200206
{
    public class DescribeConfigurationResponseUnmarshaller
    {
        public static DescribeConfigurationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConfigurationResponse describeConfigurationResponse = new DescribeConfigurationResponse();

			describeConfigurationResponse.HttpResponse = context.HttpResponse;
			describeConfigurationResponse.RequestId = context.StringValue("DescribeConfiguration.RequestId");
			describeConfigurationResponse.Message = context.StringValue("DescribeConfiguration.Message");
			describeConfigurationResponse.Code = context.StringValue("DescribeConfiguration.Code");

			DescribeConfigurationResponse.DescribeConfiguration_Configuration configuration = new DescribeConfigurationResponse.DescribeConfiguration_Configuration();
			configuration.DataId = context.StringValue("DescribeConfiguration.Configuration.DataId");
			configuration.Group = context.StringValue("DescribeConfiguration.Configuration.Group");
			configuration.Content = context.StringValue("DescribeConfiguration.Configuration.Content");
			configuration.Md5 = context.StringValue("DescribeConfiguration.Configuration.Md5");
			configuration.AppName = context.StringValue("DescribeConfiguration.Configuration.AppName");
			configuration.Desc = context.StringValue("DescribeConfiguration.Configuration.Desc");
			configuration.Tags = context.StringValue("DescribeConfiguration.Configuration.Tags");
			describeConfigurationResponse.Configuration = configuration;
        
			return describeConfigurationResponse;
        }
    }
}
