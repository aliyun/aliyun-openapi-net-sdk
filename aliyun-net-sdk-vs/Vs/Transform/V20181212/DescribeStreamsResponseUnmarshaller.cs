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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeStreamsResponseUnmarshaller
    {
        public static DescribeStreamsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamsResponse describeStreamsResponse = new DescribeStreamsResponse();

			describeStreamsResponse.HttpResponse = context.HttpResponse;
			describeStreamsResponse.RequestId = context.StringValue("DescribeStreams.RequestId");
			describeStreamsResponse.PageSize = context.LongValue("DescribeStreams.PageSize");
			describeStreamsResponse.PageNum = context.LongValue("DescribeStreams.PageNum");
			describeStreamsResponse.PageCount = context.LongValue("DescribeStreams.PageCount");
			describeStreamsResponse.TotalCount = context.LongValue("DescribeStreams.TotalCount");

			List<DescribeStreamsResponse.DescribeStreams_Stream> describeStreamsResponse_streams = new List<DescribeStreamsResponse.DescribeStreams_Stream>();
			for (int i = 0; i < context.Length("DescribeStreams.Streams.Length"); i++) {
				DescribeStreamsResponse.DescribeStreams_Stream stream = new DescribeStreamsResponse.DescribeStreams_Stream();
				stream.Id = context.StringValue("DescribeStreams.Streams["+ i +"].Id");
				stream.Name = context.StringValue("DescribeStreams.Streams["+ i +"].Name");
				stream.PushDomain = context.StringValue("DescribeStreams.Streams["+ i +"].PushDomain");
				stream.PlayDomain = context.StringValue("DescribeStreams.Streams["+ i +"].PlayDomain");
				stream.App = context.StringValue("DescribeStreams.Streams["+ i +"].App");
				stream.Protocol = context.StringValue("DescribeStreams.Streams["+ i +"].Protocol");
				stream.GroupId = context.StringValue("DescribeStreams.Streams["+ i +"].GroupId");
				stream.DeviceId = context.StringValue("DescribeStreams.Streams["+ i +"].DeviceId");
				stream.Enabled = context.BooleanValue("DescribeStreams.Streams["+ i +"].Enabled");
				stream.Status = context.StringValue("DescribeStreams.Streams["+ i +"].Status");
				stream.Height = context.IntegerValue("DescribeStreams.Streams["+ i +"].Height");
				stream.Width = context.IntegerValue("DescribeStreams.Streams["+ i +"].Width");
				stream.CreatedTime = context.StringValue("DescribeStreams.Streams["+ i +"].CreatedTime");

				describeStreamsResponse_streams.Add(stream);
			}
			describeStreamsResponse.Streams = describeStreamsResponse_streams;
        
			return describeStreamsResponse;
        }
    }
}
