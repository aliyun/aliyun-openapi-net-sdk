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
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class DescribeContactResponseUnmarshaller
    {
        public static DescribeContactResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeContactResponse describeContactResponse = new DescribeContactResponse();

			describeContactResponse.HttpResponse = context.HttpResponse;
			describeContactResponse.RequestId = context.StringValue("DescribeContact.RequestId");
			describeContactResponse.Success = context.BooleanValue("DescribeContact.Success");
			describeContactResponse.Code = context.IntegerValue("DescribeContact.Code");
			describeContactResponse.Message = context.StringValue("DescribeContact.Message");

			DescribeContactResponse.DescribeContact_Datapoints datapoints = new DescribeContactResponse.DescribeContact_Datapoints();
			datapoints.Name = context.StringValue("DescribeContact.Datapoints.Name");

			List<DescribeContactResponse.DescribeContact_Datapoints.DescribeContact_Channel> datapoints_channels = new List<DescribeContactResponse.DescribeContact_Datapoints.DescribeContact_Channel>();
			for (int i = 0; i < context.Length("DescribeContact.Datapoints.Channels.Length"); i++) {
				DescribeContactResponse.DescribeContact_Datapoints.DescribeContact_Channel channel = new DescribeContactResponse.DescribeContact_Datapoints.DescribeContact_Channel();
				channel.Type = context.StringValue("DescribeContact.Datapoints.Channels["+ i +"].Type");
				channel._Value = context.StringValue("DescribeContact.Datapoints.Channels["+ i +"].Value");

				datapoints_channels.Add(channel);
			}
			datapoints.Channels = datapoints_channels;
			describeContactResponse.Datapoints = datapoints;
        
			return describeContactResponse;
        }
    }
}