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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeEngineVersionResponse : AcsResponse
	{

		private bool? isLatestVersion;

		private string requestId;

		private string proxyMinorVersion;

		private string dBVersionRelease;

		private string proxyVersionRelease;

		private bool? enableUpgradeMajorVersion;

		private bool? enableUpgradeMinorVersion;

		private string majorVersion;

		private string engine;

		private string minorVersion;

		private string isRedisCompatibleVersion;

		private string isSSLEnable;

		private string isNewSSLMode;

		private string isAutoUpgradeOpen;

		private string isOpenNGLB;

		private DescribeEngineVersion_DBLatestMinorVersion dBLatestMinorVersion;

		private DescribeEngineVersion_ProxyLatestMinorVersion proxyLatestMinorVersion;

		public bool? IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
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

		public string ProxyMinorVersion
		{
			get
			{
				return proxyMinorVersion;
			}
			set	
			{
				proxyMinorVersion = value;
			}
		}

		public string DBVersionRelease
		{
			get
			{
				return dBVersionRelease;
			}
			set	
			{
				dBVersionRelease = value;
			}
		}

		public string ProxyVersionRelease
		{
			get
			{
				return proxyVersionRelease;
			}
			set	
			{
				proxyVersionRelease = value;
			}
		}

		public bool? EnableUpgradeMajorVersion
		{
			get
			{
				return enableUpgradeMajorVersion;
			}
			set	
			{
				enableUpgradeMajorVersion = value;
			}
		}

		public bool? EnableUpgradeMinorVersion
		{
			get
			{
				return enableUpgradeMinorVersion;
			}
			set	
			{
				enableUpgradeMinorVersion = value;
			}
		}

		public string MajorVersion
		{
			get
			{
				return majorVersion;
			}
			set	
			{
				majorVersion = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public string MinorVersion
		{
			get
			{
				return minorVersion;
			}
			set	
			{
				minorVersion = value;
			}
		}

		public string IsRedisCompatibleVersion
		{
			get
			{
				return isRedisCompatibleVersion;
			}
			set	
			{
				isRedisCompatibleVersion = value;
			}
		}

		public string IsSSLEnable
		{
			get
			{
				return isSSLEnable;
			}
			set	
			{
				isSSLEnable = value;
			}
		}

		public string IsNewSSLMode
		{
			get
			{
				return isNewSSLMode;
			}
			set	
			{
				isNewSSLMode = value;
			}
		}

		public string IsAutoUpgradeOpen
		{
			get
			{
				return isAutoUpgradeOpen;
			}
			set	
			{
				isAutoUpgradeOpen = value;
			}
		}

		public string IsOpenNGLB
		{
			get
			{
				return isOpenNGLB;
			}
			set	
			{
				isOpenNGLB = value;
			}
		}

		public DescribeEngineVersion_DBLatestMinorVersion DBLatestMinorVersion
		{
			get
			{
				return dBLatestMinorVersion;
			}
			set	
			{
				dBLatestMinorVersion = value;
			}
		}

		public DescribeEngineVersion_ProxyLatestMinorVersion ProxyLatestMinorVersion
		{
			get
			{
				return proxyLatestMinorVersion;
			}
			set	
			{
				proxyLatestMinorVersion = value;
			}
		}

		public class DescribeEngineVersion_DBLatestMinorVersion
		{

			private string minorVersion;

			private string level;

			private DescribeEngineVersion_VersionRelease versionRelease;

			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public DescribeEngineVersion_VersionRelease VersionRelease
			{
				get
				{
					return versionRelease;
				}
				set	
				{
					versionRelease = value;
				}
			}

			public class DescribeEngineVersion_VersionRelease
			{

				private string versionChangesLevel;

				private List<DescribeEngineVersion_ReleaseInfoList> releaseInfo;

				public string VersionChangesLevel
				{
					get
					{
						return versionChangesLevel;
					}
					set	
					{
						versionChangesLevel = value;
					}
				}

				public List<DescribeEngineVersion_ReleaseInfoList> ReleaseInfo
				{
					get
					{
						return releaseInfo;
					}
					set	
					{
						releaseInfo = value;
					}
				}

				public class DescribeEngineVersion_ReleaseInfoList
				{

					private string releaseVersion;

					private string createTime;

					private string releaseNote;

					private string level;

					private string releaseNoteEn;

					public string ReleaseVersion
					{
						get
						{
							return releaseVersion;
						}
						set	
						{
							releaseVersion = value;
						}
					}

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

					public string ReleaseNote
					{
						get
						{
							return releaseNote;
						}
						set	
						{
							releaseNote = value;
						}
					}

					public string Level
					{
						get
						{
							return level;
						}
						set	
						{
							level = value;
						}
					}

					public string ReleaseNoteEn
					{
						get
						{
							return releaseNoteEn;
						}
						set	
						{
							releaseNoteEn = value;
						}
					}
				}
			}
		}

		public class DescribeEngineVersion_ProxyLatestMinorVersion
		{

			private string minorVersion;

			private string level;

			private DescribeEngineVersion_VersionRelease1 versionRelease1;

			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public DescribeEngineVersion_VersionRelease1 VersionRelease1
			{
				get
				{
					return versionRelease1;
				}
				set	
				{
					versionRelease1 = value;
				}
			}

			public class DescribeEngineVersion_VersionRelease1
			{

				private string versionChangesLevel;

				private List<DescribeEngineVersion_ReleaseInfoList3> releaseInfo2;

				public string VersionChangesLevel
				{
					get
					{
						return versionChangesLevel;
					}
					set	
					{
						versionChangesLevel = value;
					}
				}

				public List<DescribeEngineVersion_ReleaseInfoList3> ReleaseInfo2
				{
					get
					{
						return releaseInfo2;
					}
					set	
					{
						releaseInfo2 = value;
					}
				}

				public class DescribeEngineVersion_ReleaseInfoList3
				{

					private string releaseVersion;

					private string createTime;

					private string releaseNote;

					private string level;

					private string releaseNoteEn;

					public string ReleaseVersion
					{
						get
						{
							return releaseVersion;
						}
						set	
						{
							releaseVersion = value;
						}
					}

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

					public string ReleaseNote
					{
						get
						{
							return releaseNote;
						}
						set	
						{
							releaseNote = value;
						}
					}

					public string Level
					{
						get
						{
							return level;
						}
						set	
						{
							level = value;
						}
					}

					public string ReleaseNoteEn
					{
						get
						{
							return releaseNoteEn;
						}
						set	
						{
							releaseNoteEn = value;
						}
					}
				}
			}
		}
	}
}
