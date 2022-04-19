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

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeVulList_VulRecord> vulRecords;

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

			private int? status;

			private string type;

			private long? modifyTs;

			private string internetIp;

			private long? recordId;

			private string containerImageId;

			private long? primaryId;

			private string tag;

			private string k8sClusterId;

			private string containerImageName;

			private string k8sNodeId;

			private string instanceName;

			private string containerInnerPath;

			private bool? online;

			private string osVersion;

			private string name;

			private string canFix;

			private int? progress;

			private string ip;

			private string needReboot;

			private string resultCode;

			private string instanceId;

			private string related;

			private string intranetIp;

			private long? lastTs;

			private long? firstTs;

			private string regionId;

			private string necessity;

			private long? repairTs;

			private string uuid;

			private string k8sPodName;

			private string containerId;

			private int? groupId;

			private string resultMessage;

			private string k8sNamespace;

			private string aliasName;

			private string k8sNodeName;

			private string containerName;

			private string level;

			private DescribeVulList_ExtendContentJson extendContentJson;

			private DescribeVulList_ProcessInfo processInfo;

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

				private string status;

				private string effect;

				private string emgProof;

				private string owasp;

				private string cwe;

				private string ip;

				private long? primaryId;

				private string os;

				private string tag;

				private string reference;

				private string wasc;

				private long? lastTs;

				private string vulType;

				private string description;

				private string osRelease;

				private string title;

				private string aliasName;

				private string solution;

				private string target;

				private string absolutePath;

				private string proof;

				private string reason;

				private List<DescribeVulList_RpmEntity> rpmEntityList;

				private List<string> cveList;

				private DescribeVulList_Necessity necessity;

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

					private string version;

					private string matchDetail;

					private string imageName;

					private string path;

					private string containerName;

					private string name;

					private string updateCmd;

					private string pid;

					private List<string> matchList;

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

					public string ImageName
					{
						get
						{
							return imageName;
						}
						set	
						{
							imageName = value;
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

					public List<string> MatchList
					{
						get
						{
							return matchList;
						}
						set	
						{
							matchList = value;
						}
					}
				}

				public class DescribeVulList_Necessity
				{

					private string status;

					private string gmt_create;

					private string time_factor;

					private string enviroment_factor;

					private string is_calc;

					private string total_score;

					private string cvss_factor;

					private string assets_factor;

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
				}
			}

			public class DescribeVulList_ProcessInfo
			{

				private int? totalCount;

				private long? gmtLastTs;

				private List<DescribeVulList_Process> processList;

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
