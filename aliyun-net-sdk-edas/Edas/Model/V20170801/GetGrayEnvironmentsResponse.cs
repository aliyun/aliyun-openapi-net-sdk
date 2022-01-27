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
	public class GetGrayEnvironmentsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private List<GetGrayEnvironments_EnvList> data;

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

		public List<GetGrayEnvironments_EnvList> Data
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

		public class GetGrayEnvironments_EnvList
		{

			private string accountId;

			private long? pointcutId;

			private string regionId;

			private string tenantId;

			private GetGrayEnvironments_Metadata metadata;

			private GetGrayEnvironments_Spec spec;

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public long? PointcutId
			{
				get
				{
					return pointcutId;
				}
				set	
				{
					pointcutId = value;
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public GetGrayEnvironments_Metadata Metadata
			{
				get
				{
					return metadata;
				}
				set	
				{
					metadata = value;
				}
			}

			public GetGrayEnvironments_Spec Spec
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

			public class GetGrayEnvironments_Metadata
			{

				private string labels;

				private string annotations;

				private string name;

				private string _namespace;

				public string Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
					}
				}

				public string Annotations
				{
					get
					{
						return annotations;
					}
					set	
					{
						annotations = value;
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
			}

			public class GetGrayEnvironments_Spec
			{

				private bool? enable;

				private string showName;

				private bool? single;

				private string tag;

				private string selector;

				private List<GetGrayEnvironments_ScopesItem> scopes;

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string ShowName
				{
					get
					{
						return showName;
					}
					set	
					{
						showName = value;
					}
				}

				public bool? Single
				{
					get
					{
						return single;
					}
					set	
					{
						single = value;
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

				public string Selector
				{
					get
					{
						return selector;
					}
					set	
					{
						selector = value;
					}
				}

				public List<GetGrayEnvironments_ScopesItem> Scopes
				{
					get
					{
						return scopes;
					}
					set	
					{
						scopes = value;
					}
				}

				public class GetGrayEnvironments_ScopesItem
				{

					private long? id;

					private string key;

					private string _value;

					private string extra;

					private GetGrayEnvironments_ValueFrom valueFrom;

					public long? Id
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

					public string Extra
					{
						get
						{
							return extra;
						}
						set	
						{
							extra = value;
						}
					}

					public GetGrayEnvironments_ValueFrom ValueFrom
					{
						get
						{
							return valueFrom;
						}
						set	
						{
							valueFrom = value;
						}
					}

					public class GetGrayEnvironments_ValueFrom
					{

						private string refName;

						private string refValue;

						public string RefName
						{
							get
							{
								return refName;
							}
							set	
							{
								refName = value;
							}
						}

						public string RefValue
						{
							get
							{
								return refValue;
							}
							set	
							{
								refValue = value;
							}
						}
					}
				}
			}
		}
	}
}
