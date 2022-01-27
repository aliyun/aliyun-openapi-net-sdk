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
	public class ToggleGrayIngressResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private int? message;

		private ToggleGrayIngress_Data data;

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

		public int? Message
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

		public ToggleGrayIngress_Data Data
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

		public class ToggleGrayIngress_Data
		{

			private long? pointcutId;

			private string regionId;

			private ToggleGrayIngress_Spec spec;

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

			public ToggleGrayIngress_Spec Spec
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

			public class ToggleGrayIngress_Spec
			{

				private string showName;

				private string tag;

				private bool? enable;

				private string selector;

				private List<ToggleGrayIngress_ScopesItem> scopes;

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

				public List<ToggleGrayIngress_ScopesItem> Scopes
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

				public class ToggleGrayIngress_ScopesItem
				{

					private long? id;

					private string key;

					private string _value;

					private ToggleGrayIngress_ValueFrom valueFrom;

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

					public ToggleGrayIngress_ValueFrom ValueFrom
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

					public class ToggleGrayIngress_ValueFrom
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
