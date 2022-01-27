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
			describeGatewayBlockVolumesResponse.Message = _ctx.StringValue("DescribeGatewayBlockVolumes.Message");
			describeGatewayBlockVolumesResponse.RequestId = _ctx.StringValue("DescribeGatewayBlockVolumes.RequestId");
			describeGatewayBlockVolumesResponse.Code = _ctx.StringValue("DescribeGatewayBlockVolumes.Code");
			describeGatewayBlockVolumesResponse.Success = _ctx.BooleanValue("DescribeGatewayBlockVolumes.Success");

			List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume> describeGatewayBlockVolumesResponse_blockVolumes = new List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayBlockVolumes.BlockVolumes.Length"); i++) {
				DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume blockVolume = new DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume();
				blockVolume.Status = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Status");
				blockVolume.SerialNumber = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].SerialNumber");
				blockVolume.ChunkSize = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChunkSize");
				blockVolume.TotalUpload = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalUpload");
				blockVolume.DiskType = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskType");
				blockVolume.DiskId = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskId");
				blockVolume.Port = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Port");
				blockVolume.IndexId = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].IndexId");
				blockVolume.ChapOutUser = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapOutUser");
				blockVolume.TotalDownload = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalDownload");
				blockVolume.ChapEnabled = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapEnabled");
				blockVolume.Enabled = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Enabled");
				blockVolume.Address = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Address");
				blockVolume.Name = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Name");
				blockVolume.Target = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Target");
				blockVolume.OssEndpoint = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssEndpoint");
				blockVolume.OssBucketName = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketName");
				blockVolume.CacheMode = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].CacheMode");
				blockVolume.State = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].State");
				blockVolume.Protocol = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Protocol");
				blockVolume.LunId = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LunId");
				blockVolume.OssBucketSsl = _ctx.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketSsl");
				blockVolume.VolumeState = _ctx.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].VolumeState");
				blockVolume.LocalPath = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LocalPath");
				blockVolume.ChapInUser = _ctx.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapInUser");
				blockVolume.Size = _ctx.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Size");

				describeGatewayBlockVolumesResponse_blockVolumes.Add(blockVolume);
			}
			describeGatewayBlockVolumesResponse.BlockVolumes = describeGatewayBlockVolumesResponse_blockVolumes;
        
			return describeGatewayBlockVolumesResponse;
        }
    }
}
