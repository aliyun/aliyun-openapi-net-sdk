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
    public class DescribeGatewayFileSharesResponseUnmarshaller
    {
        public static DescribeGatewayFileSharesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayFileSharesResponse describeGatewayFileSharesResponse = new DescribeGatewayFileSharesResponse();

			describeGatewayFileSharesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayFileSharesResponse.Message = _ctx.StringValue("DescribeGatewayFileShares.Message");
			describeGatewayFileSharesResponse.RequestId = _ctx.StringValue("DescribeGatewayFileShares.RequestId");
			describeGatewayFileSharesResponse.Code = _ctx.StringValue("DescribeGatewayFileShares.Code");
			describeGatewayFileSharesResponse.Success = _ctx.BooleanValue("DescribeGatewayFileShares.Success");

			List<DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare> describeGatewayFileSharesResponse_fileShares = new List<DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayFileShares.FileShares.Length"); i++) {
				DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare fileShare = new DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare();
				fileShare.SerialNumber = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].SerialNumber");
				fileShare.ClientSideCmk = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ClientSideCmk");
				fileShare.PartialSyncPaths = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].PartialSyncPaths");
				fileShare.PathPrefix = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].PathPrefix");
				fileShare.BucketsStub = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].BucketsStub");
				fileShare.UploadQueue = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].UploadQueue");
				fileShare.DiskId = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].DiskId");
				fileShare.OssUsed = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].OssUsed");
				fileShare.DownloadQueue = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadQueue");
				fileShare.ActiveMessages = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].ActiveMessages");
				fileShare.IndexId = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].IndexId");
				fileShare.MnsHealth = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].MnsHealth");
				fileShare.AccessBasedEnumeration = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].AccessBasedEnumeration");
				fileShare.DownloadRate = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadRate");
				fileShare.FeLimit = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].FeLimit");
				fileShare.SupportArchive = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].SupportArchive");
				fileShare.OssEndpoint = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssEndpoint");
				fileShare.OssHealth = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssHealth");
				fileShare.OutRate = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].OutRate");
				fileShare.ServerSideCmk = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ServerSideCmk");
				fileShare.RwClientList = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RwClientList");
				fileShare.State = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].State");
				fileShare.Protocol = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Protocol");
				fileShare.OssBucketSsl = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].OssBucketSsl");
				fileShare.DownloadLimit = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadLimit");
				fileShare.InPlace = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].InPlace");
				fileShare.RemoteSync = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].RemoteSync");
				fileShare.FileNumLimit = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].FileNumLimit");
				fileShare.Squash = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Squash");
				fileShare.NfsFullPath = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].NfsFullPath");
				fileShare.RemainingMetaSpace = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].RemainingMetaSpace");
				fileShare.TransferAcceleration = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].TransferAcceleration");
				fileShare.Size = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].Size");
				fileShare.ServerSideEncryption = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].ServerSideEncryption");
				fileShare.WindowsAcl = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].WindowsAcl");
				fileShare.RemoteSyncDownload = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].RemoteSyncDownload");
				fileShare.ClientSideEncryption = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].ClientSideEncryption");
				fileShare.BucketInfos = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].BucketInfos");
				fileShare.NfsV4Optimization = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].NfsV4Optimization");
				fileShare.TotalUpload = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].TotalUpload");
				fileShare.DiskType = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].DiskType");
				fileShare.Used = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].Used");
				fileShare.IgnoreDelete = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].IgnoreDelete");
				fileShare.RoUserList = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RoUserList");
				fileShare.FsSizeLimit = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].FsSizeLimit");
				fileShare.TotalDownload = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].TotalDownload");
				fileShare.Enabled = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].Enabled");
				fileShare.HighWatermark = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].HighWatermark");
				fileShare.KmsRotatePeriod = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].KmsRotatePeriod");
				fileShare.Address = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Address");
				fileShare.PollingInterval = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].PollingInterval");
				fileShare.Name = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Name");
				fileShare.OssBucketName = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssBucketName");
				fileShare.ExpressSyncId = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ExpressSyncId");
				fileShare.LagPeriod = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].LagPeriod");
				fileShare.DirectIO = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].DirectIO");
				fileShare.CacheMode = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].CacheMode");
				fileShare.InRate = _ctx.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].InRate");
				fileShare.LowWatermark = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].LowWatermark");
				fileShare.SyncProgress = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].SyncProgress");
				fileShare.ServerSideAlgorithm = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ServerSideAlgorithm");
				fileShare.ObsoleteBuckets = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ObsoleteBuckets");
				fileShare.BeLimit = _ctx.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].BeLimit");
				fileShare.LocalPath = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].LocalPath");
				fileShare.RoClientList = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RoClientList");
				fileShare.RwUserList = _ctx.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RwUserList");
				fileShare.FastReclaim = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].FastReclaim");
				fileShare.Browsable = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].Browsable");
				fileShare.Throttling = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].Throttling");
				fileShare.BypassCacheRead = _ctx.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].BypassCacheRead");

				describeGatewayFileSharesResponse_fileShares.Add(fileShare);
			}
			describeGatewayFileSharesResponse.FileShares = describeGatewayFileSharesResponse_fileShares;
        
			return describeGatewayFileSharesResponse;
        }
    }
}
