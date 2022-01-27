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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeFileSystemStatisticsResponseUnmarshaller
    {
        public static DescribeFileSystemStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFileSystemStatisticsResponse describeFileSystemStatisticsResponse = new DescribeFileSystemStatisticsResponse();

			describeFileSystemStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeFileSystemStatisticsResponse.RequestId = _ctx.StringValue("DescribeFileSystemStatistics.RequestId");
			describeFileSystemStatisticsResponse.PageSize = _ctx.IntegerValue("DescribeFileSystemStatistics.PageSize");
			describeFileSystemStatisticsResponse.PageNumber = _ctx.IntegerValue("DescribeFileSystemStatistics.PageNumber");
			describeFileSystemStatisticsResponse.TotalCount = _ctx.IntegerValue("DescribeFileSystemStatistics.TotalCount");

			List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystemStatistic> describeFileSystemStatisticsResponse_fileSystemStatistics = new List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystemStatistic>();
			for (int i = 0; i < _ctx.Length("DescribeFileSystemStatistics.FileSystemStatistics.Length"); i++) {
				DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystemStatistic fileSystemStatistic = new DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystemStatistic();
				fileSystemStatistic.FileSystemType = _ctx.StringValue("DescribeFileSystemStatistics.FileSystemStatistics["+ i +"].FileSystemType");
				fileSystemStatistic.TotalCount = _ctx.IntegerValue("DescribeFileSystemStatistics.FileSystemStatistics["+ i +"].TotalCount");
				fileSystemStatistic.MeteredSize = _ctx.LongValue("DescribeFileSystemStatistics.FileSystemStatistics["+ i +"].MeteredSize");
				fileSystemStatistic.ExpiredCount = _ctx.IntegerValue("DescribeFileSystemStatistics.FileSystemStatistics["+ i +"].ExpiredCount");
				fileSystemStatistic.ExpiringCount = _ctx.IntegerValue("DescribeFileSystemStatistics.FileSystemStatistics["+ i +"].ExpiringCount");

				describeFileSystemStatisticsResponse_fileSystemStatistics.Add(fileSystemStatistic);
			}
			describeFileSystemStatisticsResponse.FileSystemStatistics = describeFileSystemStatisticsResponse_fileSystemStatistics;

			List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem> describeFileSystemStatisticsResponse_fileSystems = new List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem>();
			for (int i = 0; i < _ctx.Length("DescribeFileSystemStatistics.FileSystems.Length"); i++) {
				DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem fileSystem = new DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem();
				fileSystem.FileSystemId = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].FileSystemId");
				fileSystem.Description = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Description");
				fileSystem.CreateTime = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].CreateTime");
				fileSystem.ExpiredTime = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].ExpiredTime");
				fileSystem.RegionId = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].RegionId");
				fileSystem.ZoneId = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].ZoneId");
				fileSystem.ProtocolType = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].ProtocolType");
				fileSystem.StorageType = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].StorageType");
				fileSystem.FileSystemType = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].FileSystemType");
				fileSystem.MeteredSize = _ctx.LongValue("DescribeFileSystemStatistics.FileSystems["+ i +"].MeteredSize");
				fileSystem.MeteredIASize = _ctx.LongValue("DescribeFileSystemStatistics.FileSystems["+ i +"].MeteredIASize");
				fileSystem.Capacity = _ctx.LongValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Capacity");
				fileSystem.ChargeType = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].ChargeType");
				fileSystem.Status = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Status");

				List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem.DescribeFileSystemStatistics_Package> fileSystem_packages = new List<DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem.DescribeFileSystemStatistics_Package>();
				for (int j = 0; j < _ctx.Length("DescribeFileSystemStatistics.FileSystems["+ i +"].Packages.Length"); j++) {
					DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem.DescribeFileSystemStatistics_Package package = new DescribeFileSystemStatisticsResponse.DescribeFileSystemStatistics_FileSystem.DescribeFileSystemStatistics_Package();
					package.PackageId = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Packages["+ j +"].PackageId");
					package.Size = _ctx.LongValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Packages["+ j +"].Size");
					package.StartTime = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Packages["+ j +"].StartTime");
					package.ExpiredTime = _ctx.StringValue("DescribeFileSystemStatistics.FileSystems["+ i +"].Packages["+ j +"].ExpiredTime");

					fileSystem_packages.Add(package);
				}
				fileSystem.Packages = fileSystem_packages;

				describeFileSystemStatisticsResponse_fileSystems.Add(fileSystem);
			}
			describeFileSystemStatisticsResponse.FileSystems = describeFileSystemStatisticsResponse_fileSystems;
        
			return describeFileSystemStatisticsResponse;
        }
    }
}
