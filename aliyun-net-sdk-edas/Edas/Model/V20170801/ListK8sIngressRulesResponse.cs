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
	public class ListK8sIngressRulesResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListK8sIngressRules_DataItem> data;

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

		public List<ListK8sIngressRules_DataItem> Data
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

		public class ListK8sIngressRules_DataItem
		{

			private string clusterId;

			private string clusterName;

			private string regionId;

			private List<ListK8sIngressRules_IngressConfsItem> ingressConfs;

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

			public List<ListK8sIngressRules_IngressConfsItem> IngressConfs
			{
				get
				{
					return ingressConfs;
				}
				set	
				{
					ingressConfs = value;
				}
			}

			public class ListK8sIngressRules_IngressConfsItem
			{

				private string name;

				private string _namespace;

				private string endpoint;

				private string creationTime;

				private string dashboardUrl;

				private List<ListK8sIngressRules_RulesItem> rules;

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

				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
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

				public string DashboardUrl
				{
					get
					{
						return dashboardUrl;
					}
					set	
					{
						dashboardUrl = value;
					}
				}

				public List<ListK8sIngressRules_RulesItem> Rules
				{
					get
					{
						return rules;
					}
					set	
					{
						rules = value;
					}
				}

				public class ListK8sIngressRules_RulesItem
				{

					private string host;

					private string secretName;

					private List<ListK8sIngressRules_PathsItem> paths;

					public string Host
					{
						get
						{
							return host;
						}
						set	
						{
							host = value;
						}
					}

					public string SecretName
					{
						get
						{
							return secretName;
						}
						set	
						{
							secretName = value;
						}
					}

					public List<ListK8sIngressRules_PathsItem> Paths
					{
						get
						{
							return paths;
						}
						set	
						{
							paths = value;
						}
					}

					public class ListK8sIngressRules_PathsItem
					{

						private string path;

						private string appId;

						private string appName;

						private string status;

						private ListK8sIngressRules_Backend backend;

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

						public ListK8sIngressRules_Backend Backend
						{
							get
							{
								return backend;
							}
							set	
							{
								backend = value;
							}
						}

						public class ListK8sIngressRules_Backend
						{

							private string serviceName;

							private string servicePort;

							public string ServiceName
							{
								get
								{
									return serviceName;
								}
								set	
								{
									serviceName = value;
								}
							}

							public string ServicePort
							{
								get
								{
									return servicePort;
								}
								set	
								{
									servicePort = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
