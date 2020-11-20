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
        public static DescribeGatewayFileSharesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayFileSharesResponse describeGatewayFileSharesResponse = new DescribeGatewayFileSharesResponse();

			describeGatewayFileSharesResponse.HttpResponse = context.HttpResponse;
			describeGatewayFileSharesResponse.RequestId = context.StringValue("DescribeGatewayFileShares.RequestId");
			describeGatewayFileSharesResponse.Success = context.BooleanValue("DescribeGatewayFileShares.Success");
			describeGatewayFileSharesResponse.Code = context.StringValue("DescribeGatewayFileShares.Code");
			describeGatewayFileSharesResponse.Message = context.StringValue("DescribeGatewayFileShares.Message");

			List<DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare> describeGatewayFileSharesResponse_fileShares = new List<DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare>();
			for (int i = 0; i < context.Length("DescribeGatewayFileShares.FileShares.Length"); i++) {
				DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare fileShare = new DescribeGatewayFileSharesResponse.DescribeGatewayFileShares_FileShare();
				fileShare.Name = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Name");
				fileShare.DiskId = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].DiskId");
				fileShare.DiskType = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].DiskType");
				fileShare.Protocol = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Protocol");
				fileShare.Size = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].Size");
				fileShare.Enabled = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].Enabled");
				fileShare.State = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].State");
				fileShare.TotalUpload = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].TotalUpload");
				fileShare.TotalDownload = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].TotalDownload");
				fileShare.OssBucketName = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssBucketName");
				fileShare.OssEndpoint = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssEndpoint");
				fileShare.OssBucketSsl = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].OssBucketSsl");
				fileShare.LocalPath = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].LocalPath");
				fileShare.CacheMode = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].CacheMode");
				fileShare.Address = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Address");
				fileShare.SerialNumber = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].SerialNumber");
				fileShare.IndexId = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].IndexId");
				fileShare.RemoteSync = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].RemoteSync");
				fileShare.PollingInterval = context.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].PollingInterval");
				fileShare.IgnoreDelete = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].IgnoreDelete");
				fileShare.FeLimit = context.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].FeLimit");
				fileShare.BeLimit = context.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].BeLimit");
				fileShare.InPlace = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].InPlace");
				fileShare.Browsable = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].Browsable");
				fileShare.Squash = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].Squash");
				fileShare.RwUserList = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RwUserList");
				fileShare.RoUserList = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RoUserList");
				fileShare.RwClientList = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RwClientList");
				fileShare.RoClientList = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].RoClientList");
				fileShare.OssUsed = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].OssUsed");
				fileShare.Used = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].Used");
				fileShare.InRate = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].InRate");
				fileShare.OutRate = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].OutRate");
				fileShare.LagPeriod = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].LagPeriod");
				fileShare.DirectIO = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].DirectIO");
				fileShare.NfsFullPath = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].NfsFullPath");
				fileShare.FileNumLimit = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].FileNumLimit");
				fileShare.FsSizeLimit = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].FsSizeLimit");
				fileShare.ServerSideEncryption = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].ServerSideEncryption");
				fileShare.ServerSideCmk = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ServerSideCmk");
				fileShare.ClientSideEncryption = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].ClientSideEncryption");
				fileShare.ClientSideCmk = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ClientSideCmk");
				fileShare.KmsRotatePeriod = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].KmsRotatePeriod");
				fileShare.OssHealth = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].OssHealth");
				fileShare.PathPrefix = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].PathPrefix");
				fileShare.FastReclaim = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].FastReclaim");
				fileShare.SupportArchive = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].SupportArchive");
				fileShare.RemainingMetaSpace = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].RemainingMetaSpace");
				fileShare.MnsHealth = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].MnsHealth");
				fileShare.ExpressSyncId = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ExpressSyncId");
				fileShare.WindowsAcl = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].WindowsAcl");
				fileShare.AccessBasedEnumeration = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].AccessBasedEnumeration");
				fileShare.NfsV4Optimization = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].NfsV4Optimization");
				fileShare.BucketsStub = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].BucketsStub");
				fileShare.BucketInfos = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].BucketInfos");
				fileShare.ObsoleteBuckets = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].ObsoleteBuckets");
				fileShare.TransferAcceleration = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].TransferAcceleration");
				fileShare.DownloadLimit = context.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadLimit");
				fileShare.RemoteSyncDownload = context.BooleanValue("DescribeGatewayFileShares.FileShares["+ i +"].RemoteSyncDownload");
				fileShare.PartialSyncPaths = context.StringValue("DescribeGatewayFileShares.FileShares["+ i +"].PartialSyncPaths");
				fileShare.SyncProgress = context.IntegerValue("DescribeGatewayFileShares.FileShares["+ i +"].SyncProgress");
				fileShare.UploadQueue = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].UploadQueue");
				fileShare.DownloadQueue = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadQueue");
				fileShare.DownloadRate = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].DownloadRate");
				fileShare.ActiveMessages = context.LongValue("DescribeGatewayFileShares.FileShares["+ i +"].ActiveMessages");

				describeGatewayFileSharesResponse_fileShares.Add(fileShare);
			}
			describeGatewayFileSharesResponse.FileShares = describeGatewayFileSharesResponse_fileShares;
        
			return describeGatewayFileSharesResponse;
        }
    }
}
