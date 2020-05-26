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
	public class DescribeDialogMessagesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeDialogMessages_AegisDynamicDialogDTO> dialogList;

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

		public List<DescribeDialogMessages_AegisDynamicDialogDTO> DialogList
		{
			get
			{
				return dialogList;
			}
			set	
			{
				dialogList = value;
			}
		}

		public class DescribeDialogMessages_AegisDynamicDialogDTO
		{

			private long? iD;

			private string dialogKey;

			private string _params;

			public long? ID
			{
				get
				{
					return iD;
				}
				set	
				{
					iD = value;
				}
			}

			public string DialogKey
			{
				get
				{
					return dialogKey;
				}
				set	
				{
					dialogKey = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}
		}
	}
}
