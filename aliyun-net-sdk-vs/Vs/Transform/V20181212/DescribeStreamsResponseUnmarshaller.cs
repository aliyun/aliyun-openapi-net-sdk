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
        public static DescribeStreamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStreamsResponse describeStreamsResponse = new DescribeStreamsResponse();

			describeStreamsResponse.HttpResponse = _ctx.HttpResponse;
			describeStreamsResponse.RequestId = _ctx.StringValue("DescribeStreams.RequestId");
			describeStreamsResponse.PageSize = _ctx.LongValue("DescribeStreams.PageSize");
			describeStreamsResponse.PageNum = _ctx.LongValue("DescribeStreams.PageNum");
			describeStreamsResponse.PageCount = _ctx.LongValue("DescribeStreams.PageCount");
			describeStreamsResponse.TotalCount = _ctx.LongValue("DescribeStreams.TotalCount");

			List<DescribeStreamsResponse.DescribeStreams_Stream> describeStreamsResponse_streams = new List<DescribeStreamsResponse.DescribeStreams_Stream>();
			for (int i = 0; i < _ctx.Length("DescribeStreams.Streams.Length"); i++) {
				DescribeStreamsResponse.DescribeStreams_Stream stream = new DescribeStreamsResponse.DescribeStreams_Stream();
				stream.Id = _ctx.StringValue("DescribeStreams.Streams["+ i +"].Id");
				stream.Name = _ctx.StringValue("DescribeStreams.Streams["+ i +"].Name");
				stream.PushDomain = _ctx.StringValue("DescribeStreams.Streams["+ i +"].PushDomain");
				stream.PlayDomain = _ctx.StringValue("DescribeStreams.Streams["+ i +"].PlayDomain");
				stream.App = _ctx.StringValue("DescribeStreams.Streams["+ i +"].App");
				stream.Protocol = _ctx.StringValue("DescribeStreams.Streams["+ i +"].Protocol");
				stream.GroupId = _ctx.StringValue("DescribeStreams.Streams["+ i +"].GroupId");
				stream.DeviceId = _ctx.StringValue("DescribeStreams.Streams["+ i +"].DeviceId");
				stream.Enabled = _ctx.BooleanValue("DescribeStreams.Streams["+ i +"].Enabled");
				stream.Status = _ctx.StringValue("DescribeStreams.Streams["+ i +"].Status");
				stream.Height = _ctx.IntegerValue("DescribeStreams.Streams["+ i +"].Height");
				stream.Width = _ctx.IntegerValue("DescribeStreams.Streams["+ i +"].Width");
				stream.CreatedTime = _ctx.StringValue("DescribeStreams.Streams["+ i +"].CreatedTime");

				describeStreamsResponse_streams.Add(stream);
			}
			describeStreamsResponse.Streams = describeStreamsResponse_streams;
        
			return describeStreamsResponse;
        }
    }
}
