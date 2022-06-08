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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeMigrateTaskByIdResponse : AcsResponse
	{

		private string status;

		private string endTime;

		private string dBInstanceName;

		private string requestId;

		private string description;

		private string createTime;

		private string dBName;

		private string backupMode;

		private string migrateTaskId;

		private string isDBReplaced;

		[JsonProperty(PropertyName = "Status")]
		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		[JsonProperty(PropertyName = "DBInstanceName")]
		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		[JsonProperty(PropertyName = "CreateTime")]
		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		[JsonProperty(PropertyName = "DBName")]
		public string DBName
		{
			get
			{
				return dBName;
			}
			set	
			{
				dBName = value;
			}
		}

		[JsonProperty(PropertyName = "BackupMode")]
		public string BackupMode
		{
			get
			{
				return backupMode;
			}
			set	
			{
				backupMode = value;
			}
		}

		[JsonProperty(PropertyName = "MigrateTaskId")]
		public string MigrateTaskId
		{
			get
			{
				return migrateTaskId;
			}
			set	
			{
				migrateTaskId = value;
			}
		}

		[JsonProperty(PropertyName = "IsDBReplaced")]
		public string IsDBReplaced
		{
			get
			{
				return isDBReplaced;
			}
			set	
			{
				isDBReplaced = value;
			}
		}
	}
}
