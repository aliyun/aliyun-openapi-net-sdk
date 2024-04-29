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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeStreamLocationBlockResponseUnmarshaller
    {
        public static DescribeStreamLocationBlockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStreamLocationBlockResponse describeStreamLocationBlockResponse = new DescribeStreamLocationBlockResponse();

			describeStreamLocationBlockResponse.HttpResponse = _ctx.HttpResponse;
			describeStreamLocationBlockResponse.Count = _ctx.IntegerValue("DescribeStreamLocationBlock.Count");
			describeStreamLocationBlockResponse.PageNum = _ctx.IntegerValue("DescribeStreamLocationBlock.PageNum");
			describeStreamLocationBlockResponse.PageSize = _ctx.IntegerValue("DescribeStreamLocationBlock.PageSize");
			describeStreamLocationBlockResponse.RequestId = _ctx.StringValue("DescribeStreamLocationBlock.RequestId");
			describeStreamLocationBlockResponse.TotalPage = _ctx.IntegerValue("DescribeStreamLocationBlock.TotalPage");

			List<DescribeStreamLocationBlockResponse.DescribeStreamLocationBlock_StreamBlock> describeStreamLocationBlockResponse_streamBlockList = new List<DescribeStreamLocationBlockResponse.DescribeStreamLocationBlock_StreamBlock>();
			for (int i = 0; i < _ctx.Length("DescribeStreamLocationBlock.StreamBlockList.Length"); i++) {
				DescribeStreamLocationBlockResponse.DescribeStreamLocationBlock_StreamBlock streamBlock = new DescribeStreamLocationBlockResponse.DescribeStreamLocationBlock_StreamBlock();
				streamBlock.AppName = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].AppName");
				streamBlock.BlockType = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].BlockType");
				streamBlock.DomainName = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].DomainName");
				streamBlock.LocationList = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].LocationList");
				streamBlock.ReleaseTime = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].ReleaseTime");
				streamBlock.Status = _ctx.IntegerValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].Status");
				streamBlock.StreamName = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].StreamName");
				streamBlock.UpdateTime = _ctx.StringValue("DescribeStreamLocationBlock.StreamBlockList["+ i +"].UpdateTime");

				describeStreamLocationBlockResponse_streamBlockList.Add(streamBlock);
			}
			describeStreamLocationBlockResponse.StreamBlockList = describeStreamLocationBlockResponse_streamBlockList;
        
			return describeStreamLocationBlockResponse;
        }
    }
}
