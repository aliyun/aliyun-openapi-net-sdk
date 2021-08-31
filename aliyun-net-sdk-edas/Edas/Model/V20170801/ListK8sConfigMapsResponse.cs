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
	public class ListK8sConfigMapsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private List<ListK8sConfigMaps_ResultItem> result;

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

		public List<ListK8sConfigMaps_ResultItem> Result
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

		public class ListK8sConfigMaps_ResultItem
		{

			private int? total;

			private List<ListK8sConfigMaps_ConfigMapsItem> configMaps;

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

			public List<ListK8sConfigMaps_ConfigMapsItem> ConfigMaps
			{
				get
				{
					return configMaps;
				}
				set	
				{
					configMaps = value;
				}
			}

			public class ListK8sConfigMaps_ConfigMapsItem
			{

				private string name;

				private string _namespace;

				private string clusterId;

				private string clusterName;

				private string creationTime;

				private List<ListK8sConfigMaps_DataItem> data;

				private List<ListK8sConfigMaps_RelatedAppsItem> relatedApps;

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

				public List<ListK8sConfigMaps_DataItem> Data
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

				public List<ListK8sConfigMaps_RelatedAppsItem> RelatedApps
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

				public class ListK8sConfigMaps_DataItem
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

				public class ListK8sConfigMaps_RelatedAppsItem
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
