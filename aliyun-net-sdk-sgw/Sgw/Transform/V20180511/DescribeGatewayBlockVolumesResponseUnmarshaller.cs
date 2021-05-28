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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayBlockVolumesResponseUnmarshaller
    {
        public static DescribeGatewayBlockVolumesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayBlockVolumesResponse describeGatewayBlockVolumesResponse = new DescribeGatewayBlockVolumesResponse();

			describeGatewayBlockVolumesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayBlockVolumesResponse.RequestId = _ctx.StringValue("DescribeGatewayBlockVolumes.RequestId");
			describeGatewayBlockVolumesResponse.Success = _ctx.BooleanValue("DescribeGatewayBlockVolumes.Success");
			describeGatewayBlockVolumesResponse.Code = _ctx.StringValue("DescribeGatewayBlockVolumes.Code");
			describeGatewayBlockVolumesResponse.Message = _ctx.StringValue("DescribeGatewayBlockVolumes.Message");

			List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume> describeGatewayBlockVolumesResponse_blockVolumes = new List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayBlockVolumes.BlockVolumes.Length"); i++) {
				DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume blockVolume = new DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume();
				blockVolume.Name = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Name");
				blockVolume.DiskId = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskId");
				blockVolume.DiskType = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskType");
				blockVolume.Protocol = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Protocol");
				blockVolume.Size = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Size");
				blockVolume.Enabled = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Enabled");
				blockVolume.State = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].State");
				blockVolume.TotalUpload = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalUpload");
				blockVolume.TotalDownload = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalDownload");
				blockVolume.OssBucketName = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketName");
				blockVolume.OssEndpoint = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssEndpoint");
				blockVolume.OssBucketSsl = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketSsl");
				blockVolume.LocalPath = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LocalPath");
				blockVolume.ChunkSize = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChunkSize");
				blockVolume.CacheMode = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].CacheMode");
				blockVolume.Address = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Address");
				blockVolume.SerialNumber = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].SerialNumber");
				blockVolume.IndexId = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].IndexId");
				blockVolume.Target = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Target");
				blockVolume.Port = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Port");
				blockVolume.LunId = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LunId");
				blockVolume.ChapEnabled = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapEnabled");
				blockVolume.ChapInUser = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapInUser");
				blockVolume.ChapOutUser = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapOutUser");
				blockVolume.Status = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Status");
				blockVolume.VolumeState = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].VolumeState");

				describeGatewayBlockVolumesResponse_blockVolumes.Add(blockVolume);
			}
			describeGatewayBlockVolumesResponse.BlockVolumes = describeGatewayBlockVolumesResponse_blockVolumes;
        
			return describeGatewayBlockVolumesResponse;
        }
    }
}
