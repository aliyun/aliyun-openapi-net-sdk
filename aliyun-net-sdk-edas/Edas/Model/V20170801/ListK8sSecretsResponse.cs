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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListK8sSecretsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListK8sSecrets_ResultItem> result;

		public int? Code
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

		public List<ListK8sSecrets_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListK8sSecrets_ResultItem
		{

			private int? total;

			private List<ListK8sSecrets_SecretsItem> secrets;

			public int? Total
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

			public List<ListK8sSecrets_SecretsItem> Secrets
			{
				get
				{
					return secrets;
				}
				set	
				{
					secrets = value;
				}
			}

			public class ListK8sSecrets_SecretsItem
			{

				private string name;

				private string _namespace;

				private string creationTime;

				private string type;

				private string clusterId;

				private string clusterName;

				private string certId;

				private string certRegionId;

				private List<ListK8sSecrets_DataItem> data;

				private List<ListK8sSecrets_RelatedAppsItem> relatedApps;

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

				public string _Namespace
				{
					get
					{
						return _namespace;
					}
					set	
					{
						_namespace = value;
					}
				}

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
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

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
					}
				}

				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				public string CertId
				{
					get
					{
						return certId;
					}
					set	
					{
						certId = value;
					}
				}

				public string CertRegionId
				{
					get
					{
						return certRegionId;
					}
					set	
					{
						certRegionId = value;
					}
				}

				public List<ListK8sSecrets_DataItem> Data
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

				public List<ListK8sSecrets_RelatedAppsItem> RelatedApps
				{
					get
					{
						return relatedApps;
					}
					set	
					{
						relatedApps = value;
					}
				}

				public class ListK8sSecrets_DataItem
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}

				public class ListK8sSecrets_RelatedAppsItem
				{

					private string appName;

					private string appId;

					public string AppName
					{
						get
						{
							return appName;
						}
						set	
						{
							appName = value;
						}
					}

					public string AppId
					{
						get
						{
							return appId;
						}
						set	
						{
							appId = value;
						}
					}
				}
			}
		}
	}
}
