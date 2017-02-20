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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeBackupsResponse : AcsResponse
	{
	    public string TotalRecordCount { get; set; }

	    public string PageNumber { get; set; }

	    public string PageRecordCount { get; set; }

	    public List<Backup> Items { get; set; }

	    public class Backup{
	        public string BackupId { get; set; }

	        public string DBInstanceId { get; set; }

	        public BackupStatusEnum? BackupStatus { get; set; }

	        public string BackupStartTime { get; set; }

	        public string BackupEndTime { get; set; }

	        public BackupTypeEnum? BackupType { get; set; }

	        public BackupModeEnum? BackupMode { get; set; }

	        public BackupMethodEnum? BackupMethod { get; set; }

	        public string BackupDownloadURL { get; set; }

	        public string BackupLocation { get; set; }

	        public BackupExtractionStatusEnum? BackupExtractionStatus { get; set; }

	        public BackupScaleEnum? BackupScale { get; set; }

	        public string BackupDBNames { get; set; }

	        public long? BackupSize { get; set; }

	        public enum BackupStatusEnum {
			
					Failed,
					Success,
			}

			public enum BackupTypeEnum {
			
					IncrementalBackup,
					FullBackup,
			}

			public enum BackupModeEnum {
			
					Manual,
					Automated,
			}

			public enum BackupMethodEnum {
			
					Physical,
					Logical,
			}

			public enum BackupExtractionStatusEnum {
			
					Nostart,
					Extracing,
					Failed,
					Success,
			}

			public enum BackupScaleEnum {
			
					DBInstance,
					Database,
			}
		}
	}
}