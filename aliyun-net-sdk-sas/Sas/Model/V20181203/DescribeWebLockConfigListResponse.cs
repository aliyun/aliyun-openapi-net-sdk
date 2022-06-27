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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeWebLockConfigListResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeWebLockConfigList_ConfigInfo> configList;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

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

		public List<DescribeWebLockConfigList_ConfigInfo> ConfigList
		{
			get
			{
				return configList;
			}
			set	
			{
				configList = value;
			}
		}

		public class DescribeWebLockConfigList_ConfigInfo
		{

			private string exclusiveDir;

			private string uuid;

			private string inclusiveFileType;

			private string defenceMode;

			private string exclusiveFileType;

			private string inclusiveFile;

			private string mode;

			private string dir;

			private string exclusiveFile;

			private string id;

			private string localBackupDir;

			public string ExclusiveDir
			{
				get
				{
					return exclusiveDir;
				}
				set	
				{
					exclusiveDir = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string InclusiveFileType
			{
				get
				{
					return inclusiveFileType;
				}
				set	
				{
					inclusiveFileType = value;
				}
			}

			public string DefenceMode
			{
				get
				{
					return defenceMode;
				}
				set	
				{
					defenceMode = value;
				}
			}

			public string ExclusiveFileType
			{
				get
				{
					return exclusiveFileType;
				}
				set	
				{
					exclusiveFileType = value;
				}
			}

			public string InclusiveFile
			{
				get
				{
					return inclusiveFile;
				}
				set	
				{
					inclusiveFile = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string Dir
			{
				get
				{
					return dir;
				}
				set	
				{
					dir = value;
				}
			}

			public string ExclusiveFile
			{
				get
				{
					return exclusiveFile;
				}
				set	
				{
					exclusiveFile = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string LocalBackupDir
			{
				get
				{
					return localBackupDir;
				}
				set	
				{
					localBackupDir = value;
				}
			}
		}
	}
}
