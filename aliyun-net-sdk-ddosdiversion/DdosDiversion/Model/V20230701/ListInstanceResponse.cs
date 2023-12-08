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

namespace Aliyun.Acs.DdosDiversion.Model.V20230701
{
	public class ListInstanceResponse : AcsResponse
	{

		private long? code;

		private string requestId;

		private string message;

		private List<ListInstance_DataItem> data;

		public long? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<ListInstance_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListInstance_DataItem
		{

			private long? total;

			private long? page;

			private long? num;

			private List<ListInstance_Data> instances;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public long? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public long? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			public List<ListInstance_Data> Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public class ListInstance_Data
			{

				private string userId;

				private string saleId;

				private string instanceId;

				private string name;

				private string status;

				private string comment;

				private string message;

				private string gmtExpire;

				private string gmtCreate;

				private string gmtModify;

				private ListInstance_Spec spec;

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string SaleId
				{
					get
					{
						return saleId;
					}
					set	
					{
						saleId = value;
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

				public string Comment
				{
					get
					{
						return comment;
					}
					set	
					{
						comment = value;
					}
				}

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}

				public string GmtExpire
				{
					get
					{
						return gmtExpire;
					}
					set	
					{
						gmtExpire = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModify
				{
					get
					{
						return gmtModify;
					}
					set	
					{
						gmtModify = value;
					}
				}

				public ListInstance_Spec Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public class ListInstance_Spec
				{

					private string idcNumbers;

					private string normalBandwidth;

					private string ipSubnetNums;

					private string coverage;

					private string edition;

					private string mitigationCapacity;

					private string mitigationNums;

					private string diversionType;

					private string mitigationAnalysis;

					private string mitigationAnalysisCapacity;

					private string initialInstallation;

					private string initialQty;

					public string IdcNumbers
					{
						get
						{
							return idcNumbers;
						}
						set	
						{
							idcNumbers = value;
						}
					}

					public string NormalBandwidth
					{
						get
						{
							return normalBandwidth;
						}
						set	
						{
							normalBandwidth = value;
						}
					}

					public string IpSubnetNums
					{
						get
						{
							return ipSubnetNums;
						}
						set	
						{
							ipSubnetNums = value;
						}
					}

					public string Coverage
					{
						get
						{
							return coverage;
						}
						set	
						{
							coverage = value;
						}
					}

					public string Edition
					{
						get
						{
							return edition;
						}
						set	
						{
							edition = value;
						}
					}

					public string MitigationCapacity
					{
						get
						{
							return mitigationCapacity;
						}
						set	
						{
							mitigationCapacity = value;
						}
					}

					public string MitigationNums
					{
						get
						{
							return mitigationNums;
						}
						set	
						{
							mitigationNums = value;
						}
					}

					public string DiversionType
					{
						get
						{
							return diversionType;
						}
						set	
						{
							diversionType = value;
						}
					}

					public string MitigationAnalysis
					{
						get
						{
							return mitigationAnalysis;
						}
						set	
						{
							mitigationAnalysis = value;
						}
					}

					public string MitigationAnalysisCapacity
					{
						get
						{
							return mitigationAnalysisCapacity;
						}
						set	
						{
							mitigationAnalysisCapacity = value;
						}
					}

					public string InitialInstallation
					{
						get
						{
							return initialInstallation;
						}
						set	
						{
							initialInstallation = value;
						}
					}

					public string InitialQty
					{
						get
						{
							return initialQty;
						}
						set	
						{
							initialQty = value;
						}
					}
				}
			}
		}
	}
}
