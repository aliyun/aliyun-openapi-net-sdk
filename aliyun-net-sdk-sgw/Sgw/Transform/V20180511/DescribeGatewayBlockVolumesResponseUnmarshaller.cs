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
        public static DescribeGatewayBlockVolumesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayBlockVolumesResponse describeGatewayBlockVolumesResponse = new DescribeGatewayBlockVolumesResponse();

			describeGatewayBlockVolumesResponse.HttpResponse = context.HttpResponse;
			describeGatewayBlockVolumesResponse.RequestId = context.StringValue("DescribeGatewayBlockVolumes.RequestId");
			describeGatewayBlockVolumesResponse.Success = context.BooleanValue("DescribeGatewayBlockVolumes.Success");
			describeGatewayBlockVolumesResponse.Code = context.StringValue("DescribeGatewayBlockVolumes.Code");
			describeGatewayBlockVolumesResponse.Message = context.StringValue("DescribeGatewayBlockVolumes.Message");

			List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume> describeGatewayBlockVolumesResponse_blockVolumes = new List<DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume>();
			for (int i = 0; i < context.Length("DescribeGatewayBlockVolumes.BlockVolumes.Length"); i++) {
				DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume blockVolume = new DescribeGatewayBlockVolumesResponse.DescribeGatewayBlockVolumes_BlockVolume();
				blockVolume.Name = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Name");
				blockVolume.DiskId = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskId");
				blockVolume.DiskType = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].DiskType");
				blockVolume.Protocol = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Protocol");
				blockVolume.Size = context.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Size");
				blockVolume.Enabled = context.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Enabled");
				blockVolume.State = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].State");
				blockVolume.TotalUpload = context.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalUpload");
				blockVolume.TotalDownload = context.LongValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].TotalDownload");
				blockVolume.OssBucketName = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketName");
				blockVolume.OssEndpoint = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssEndpoint");
				blockVolume.OssBucketSsl = context.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].OssBucketSsl");
				blockVolume.LocalPath = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LocalPath");
				blockVolume.ChunkSize = context.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChunkSize");
				blockVolume.CacheMode = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].CacheMode");
				blockVolume.Address = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Address");
				blockVolume.SerialNumber = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].SerialNumber");
				blockVolume.IndexId = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].IndexId");
				blockVolume.Target = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Target");
				blockVolume.Port = context.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Port");
				blockVolume.LunId = context.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].LunId");
				blockVolume.ChapEnabled = context.BooleanValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapEnabled");
				blockVolume.ChapInUser = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapInUser");
				blockVolume.ChapOutUser = context.StringValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].ChapOutUser");
				blockVolume.Status = context.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].Status");
				blockVolume.VolumeState = context.IntegerValue("DescribeGatewayBlockVolumes.BlockVolumes["+ i +"].VolumeState");

				describeGatewayBlockVolumesResponse_blockVolumes.Add(blockVolume);
			}
			describeGatewayBlockVolumesResponse.BlockVolumes = describeGatewayBlockVolumesResponse_blockVolumes;
        
			return describeGatewayBlockVolumesResponse;
        }
    }
}
