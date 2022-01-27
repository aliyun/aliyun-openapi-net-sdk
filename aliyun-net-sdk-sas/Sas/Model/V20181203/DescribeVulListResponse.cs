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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeVulListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeVulList_VulRecord> vulRecords;

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

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

		public List<DescribeVulList_VulRecord> VulRecords
		{
			get
			{
				return vulRecords;
			}
			set	
			{
				vulRecords = value;
			}
		}

		public class DescribeVulList_VulRecord
		{

			private long? primaryId;

			private string uuid;

			private string name;

			private string tag;

			private string type;

			private string aliasName;

			private long? firstTs;

			private long? lastTs;

			private long? repairTs;

			private int? status;

			private string related;

			private long? recordId;

			private string resultCode;

			private string resultMessage;

			private long? modifyTs;

			private string necessity;

			private int? groupId;

			private string instanceId;

			private string instanceName;

			private string regionId;

			private bool? online;

			private string level;

			private string internetIp;

			private string intranetIp;

			private string ip;

			private string osVersion;

			private string needReboot;

			private int? progress;

			private string canFix;

			private string containerImageId;

			private string containerImageName;

			private string containerName;

			private string containerInnerPath;

			private string containerId;

			private string k8sNamespace;

			private string k8sClusterId;

			private string k8sNodeId;

			private string k8sPodName;

			private string k8sNodeName;

			private DescribeVulList_ExtendContentJson extendContentJson;

			private DescribeVulList_ProcessInfo processInfo;

			public long? PrimaryId
			{
				get
				{
					return primaryId;
				}
				set	
				{
					primaryId = value;
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string AliasName
			{
				get
				{
					return aliasName;
				}
				set	
				{
					aliasName = value;
				}
			}

			public long? FirstTs
			{
				get
				{
					return firstTs;
				}
				set	
				{
					firstTs = value;
				}
			}

			public long? LastTs
			{
				get
				{
					return lastTs;
				}
				set	
				{
					lastTs = value;
				}
			}

			public long? RepairTs
			{
				get
				{
					return repairTs;
				}
				set	
				{
					repairTs = value;
				}
			}

			public int? Status
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

			public string Related
			{
				get
				{
					return related;
				}
				set	
				{
					related = value;
				}
			}

			public long? RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
				}
			}

			public string ResultCode
			{
				get
				{
					return resultCode;
				}
				set	
				{
					resultCode = value;
				}
			}

			public string ResultMessage
			{
				get
				{
					return resultMessage;
				}
				set	
				{
					resultMessage = value;
				}
			}

			public long? ModifyTs
			{
				get
				{
					return modifyTs;
				}
				set	
				{
					modifyTs = value;
				}
			}

			public string Necessity
			{
				get
				{
					return necessity;
				}
				set	
				{
					necessity = value;
				}
			}

			public int? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
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

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string OsVersion
			{
				get
				{
					return osVersion;
				}
				set	
				{
					osVersion = value;
				}
			}

			public string NeedReboot
			{
				get
				{
					return needReboot;
				}
				set	
				{
					needReboot = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string CanFix
			{
				get
				{
					return canFix;
				}
				set	
				{
					canFix = value;
				}
			}

			public string ContainerImageId
			{
				get
				{
					return containerImageId;
				}
				set	
				{
					containerImageId = value;
				}
			}

			public string ContainerImageName
			{
				get
				{
					return containerImageName;
				}
				set	
				{
					containerImageName = value;
				}
			}

			public string ContainerName
			{
				get
				{
					return containerName;
				}
				set	
				{
					containerName = value;
				}
			}

			public string ContainerInnerPath
			{
				get
				{
					return containerInnerPath;
				}
				set	
				{
					containerInnerPath = value;
				}
			}

			public string ContainerId
			{
				get
				{
					return containerId;
				}
				set	
				{
					containerId = value;
				}
			}

			public string K8sNamespace
			{
				get
				{
					return k8sNamespace;
				}
				set	
				{
					k8sNamespace = value;
				}
			}

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
				}
			}

			public string K8sNodeId
			{
				get
				{
					return k8sNodeId;
				}
				set	
				{
					k8sNodeId = value;
				}
			}

			public string K8sPodName
			{
				get
				{
					return k8sPodName;
				}
				set	
				{
					k8sPodName = value;
				}
			}

			public string K8sNodeName
			{
				get
				{
					return k8sNodeName;
				}
				set	
				{
					k8sNodeName = value;
				}
			}

			public DescribeVulList_ExtendContentJson ExtendContentJson
			{
				get
				{
					return extendContentJson;
				}
				set	
				{
					extendContentJson = value;
				}
			}

			public DescribeVulList_ProcessInfo ProcessInfo
			{
				get
				{
					return processInfo;
				}
				set	
				{
					processInfo = value;
				}
			}

			public class DescribeVulList_ExtendContentJson
			{

				private string os;

				private string osRelease;

				private string status;

				private long? lastTs;

				private string aliasName;

				private string tag;

				private long? primaryId;

				private string absolutePath;

				private string target;

				private string emgProof;

				private string reason;

				private string title;

				private string description;

				private string ip;

				private string owasp;

				private string cwe;

				private string wasc;

				private string vulType;

				private string effect;

				private string solution;

				private string reference;

				private string proof;

				private List<DescribeVulList_RpmEntity> rpmEntityList;

				private List<string> cveList;

				private DescribeVulList_Necessity necessity;

				public string Os
				{
					get
					{
						return os;
					}
					set	
					{
						os = value;
					}
				}

				public string OsRelease
				{
					get
					{
						return osRelease;
					}
					set	
					{
						osRelease = value;
					}
				}

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

				public long? LastTs
				{
					get
					{
						return lastTs;
					}
					set	
					{
						lastTs = value;
					}
				}

				public string AliasName
				{
					get
					{
						return aliasName;
					}
					set	
					{
						aliasName = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public long? PrimaryId
				{
					get
					{
						return primaryId;
					}
					set	
					{
						primaryId = value;
					}
				}

				public string AbsolutePath
				{
					get
					{
						return absolutePath;
					}
					set	
					{
						absolutePath = value;
					}
				}

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}

				public string EmgProof
				{
					get
					{
						return emgProof;
					}
					set	
					{
						emgProof = value;
					}
				}

				public string Reason
				{
					get
					{
						return reason;
					}
					set	
					{
						reason = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

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

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public string Owasp
				{
					get
					{
						return owasp;
					}
					set	
					{
						owasp = value;
					}
				}

				public string Cwe
				{
					get
					{
						return cwe;
					}
					set	
					{
						cwe = value;
					}
				}

				public string Wasc
				{
					get
					{
						return wasc;
					}
					set	
					{
						wasc = value;
					}
				}

				public string VulType
				{
					get
					{
						return vulType;
					}
					set	
					{
						vulType = value;
					}
				}

				public string Effect
				{
					get
					{
						return effect;
					}
					set	
					{
						effect = value;
					}
				}

				public string Solution
				{
					get
					{
						return solution;
					}
					set	
					{
						solution = value;
					}
				}

				public string Reference
				{
					get
					{
						return reference;
					}
					set	
					{
						reference = value;
					}
				}

				public string Proof
				{
					get
					{
						return proof;
					}
					set	
					{
						proof = value;
					}
				}

				public List<DescribeVulList_RpmEntity> RpmEntityList
				{
					get
					{
						return rpmEntityList;
					}
					set	
					{
						rpmEntityList = value;
					}
				}

				public List<string> CveList
				{
					get
					{
						return cveList;
					}
					set	
					{
						cveList = value;
					}
				}

				public DescribeVulList_Necessity Necessity
				{
					get
					{
						return necessity;
					}
					set	
					{
						necessity = value;
					}
				}

				public class DescribeVulList_RpmEntity
				{

					private string fullVersion;

					private string matchDetail;

					private string name;

					private string path;

					private string updateCmd;

					private string version;

					public string FullVersion
					{
						get
						{
							return fullVersion;
						}
						set	
						{
							fullVersion = value;
						}
					}

					public string MatchDetail
					{
						get
						{
							return matchDetail;
						}
						set	
						{
							matchDetail = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string Path
					{
						get
						{
							return path;
						}
						set	
						{
							path = value;
						}
					}

					public string UpdateCmd
					{
						get
						{
							return updateCmd;
						}
						set	
						{
							updateCmd = value;
						}
					}

					public string Version
					{
						get
						{
							return version;
						}
						set	
						{
							version = value;
						}
					}
				}

				public class DescribeVulList_Necessity
				{

					private string cvss_factor;

					private string gmt_create;

					private string status;

					private string enviroment_factor;

					private string assets_factor;

					private string is_calc;

					private string total_score;

					private string time_factor;

					public string Cvss_factor
					{
						get
						{
							return cvss_factor;
						}
						set	
						{
							cvss_factor = value;
						}
					}

					public string Gmt_create
					{
						get
						{
							return gmt_create;
						}
						set	
						{
							gmt_create = value;
						}
					}

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

					public string Enviroment_factor
					{
						get
						{
							return enviroment_factor;
						}
						set	
						{
							enviroment_factor = value;
						}
					}

					public string Assets_factor
					{
						get
						{
							return assets_factor;
						}
						set	
						{
							assets_factor = value;
						}
					}

					public string Is_calc
					{
						get
						{
							return is_calc;
						}
						set	
						{
							is_calc = value;
						}
					}

					public string Total_score
					{
						get
						{
							return total_score;
						}
						set	
						{
							total_score = value;
						}
					}

					public string Time_factor
					{
						get
						{
							return time_factor;
						}
						set	
						{
							time_factor = value;
						}
					}
				}
			}

			public class DescribeVulList_ProcessInfo
			{

				private long? gmtLastTs;

				private int? totalCount;

				private List<DescribeVulList_Process> processList;

				public long? GmtLastTs
				{
					get
					{
						return gmtLastTs;
					}
					set	
					{
						gmtLastTs = value;
					}
				}

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

				public List<DescribeVulList_Process> ProcessList
				{
					get
					{
						return processList;
					}
					set	
					{
						processList = value;
					}
				}

				public class DescribeVulList_Process
				{

					private string rpm;

					private string pname;

					private string pid;

					private List<DescribeVulList_SubProcess> subProcessList;

					public string Rpm
					{
						get
						{
							return rpm;
						}
						set	
						{
							rpm = value;
						}
					}

					public string Pname
					{
						get
						{
							return pname;
						}
						set	
						{
							pname = value;
						}
					}

					public string Pid
					{
						get
						{
							return pid;
						}
						set	
						{
							pid = value;
						}
					}

					public List<DescribeVulList_SubProcess> SubProcessList
					{
						get
						{
							return subProcessList;
						}
						set	
						{
							subProcessList = value;
						}
					}

					public class DescribeVulList_SubProcess
					{

						private string rpm;

						private string pname;

						private string pid;

						public string Rpm
						{
							get
							{
								return rpm;
							}
							set	
							{
								rpm = value;
							}
						}

						public string Pname
						{
							get
							{
								return pname;
							}
							set	
							{
								pname = value;
							}
						}

						public string Pid
						{
							get
							{
								return pid;
							}
							set	
							{
								pid = value;
							}
						}
					}
				}
			}
		}
	}
}
