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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListMenusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<ListMenus_DataItem> data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<ListMenus_DataItem> Data
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

		public class ListMenus_DataItem
		{

			private long? id;

			private string name;

			private long? parentId;

			private int? sequence;

			private List<ListMenus_AclItem> acl;

			private List<ListMenus_ChildModuleItem> childModule;

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

			public long? ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public int? Sequence
			{
				get
				{
					return sequence;
				}
				set	
				{
					sequence = value;
				}
			}

			public List<ListMenus_AclItem> Acl
			{
				get
				{
					return acl;
				}
				set	
				{
					acl = value;
				}
			}

			public List<ListMenus_ChildModuleItem> ChildModule
			{
				get
				{
					return childModule;
				}
				set	
				{
					childModule = value;
				}
			}

			public class ListMenus_AclItem
			{

				private long? id;

				private string name;

				private string code;

				private int? type;

				private int? status;

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

				public string Code
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

				public int? Type
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
			}

			public class ListMenus_ChildModuleItem
			{

				private long? id;

				private string name;

				private long? parentId;

				private int? sequence;

				private List<ListMenus_AclItem2> acl1;

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

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public int? Sequence
				{
					get
					{
						return sequence;
					}
					set	
					{
						sequence = value;
					}
				}

				public List<ListMenus_AclItem2> Acl1
				{
					get
					{
						return acl1;
					}
					set	
					{
						acl1 = value;
					}
				}

				public class ListMenus_AclItem2
				{

					private long? id;

					private string name;

					private string code;

					private int? type;

					private int? status;

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

					public string Code
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

					public int? Type
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
				}
			}
		}
	}
}
