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

namespace Aliyun.Acs.Crm.Model.V20150408
{
	public class BatchGetAliyunIdByAliyunPkResponse : AcsResponse
	{

		private string requestId;

		private List<BatchGetAliyunIdByAliyunPk_ProfileItem> profileList;

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

		public List<BatchGetAliyunIdByAliyunPk_ProfileItem> ProfileList
		{
			get
			{
				return profileList;
			}
			set	
			{
				profileList = value;
			}
		}

		public class BatchGetAliyunIdByAliyunPk_ProfileItem
		{

			private string aliyunId;

			private string aliyunPk;

			public string AliyunId
			{
				get
				{
					return aliyunId;
				}
				set	
				{
					aliyunId = value;
				}
			}

			public string AliyunPk
			{
				get
				{
					return aliyunPk;
				}
				set	
				{
					aliyunPk = value;
				}
			}
		}
	}
}
