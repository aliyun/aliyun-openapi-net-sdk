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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListColumnWithLabelPermissionResponse : AcsResponse
	{

		private string requestId;

		private List<ListColumnWithLabelPermission_ColumnMetaItem> columnMeta;

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

		public List<ListColumnWithLabelPermission_ColumnMetaItem> ColumnMeta
		{
			get
			{
				return columnMeta;
			}
			set	
			{
				columnMeta = value;
			}
		}

		public class ListColumnWithLabelPermission_ColumnMetaItem
		{

			private string guid;

			private string name;

			private string comment;

			private string securityLevel;

			private string deadline;

			private string grantedLabel;

			public string Guid
			{
				get
				{
					return guid;
				}
				set	
				{
					guid = value;
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

			public string SecurityLevel
			{
				get
				{
					return securityLevel;
				}
				set	
				{
					securityLevel = value;
				}
			}

			public string Deadline
			{
				get
				{
					return deadline;
				}
				set	
				{
					deadline = value;
				}
			}

			public string GrantedLabel
			{
				get
				{
					return grantedLabel;
				}
				set	
				{
					grantedLabel = value;
				}
			}
		}
	}
}
