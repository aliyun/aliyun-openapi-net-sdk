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

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
	public class DescribeVerifySettingResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVerifySetting_VerifySetting> verifySettingList;

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

		public List<DescribeVerifySetting_VerifySetting> VerifySettingList
		{
			get
			{
				return verifySettingList;
			}
			set	
			{
				verifySettingList = value;
			}
		}

		public class DescribeVerifySetting_VerifySetting
		{

			private string bizType;

			private string bizName;

			private string solution;

			private List<string> stepList;

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BizName
			{
				get
				{
					return bizName;
				}
				set	
				{
					bizName = value;
				}
			}

			public string Solution
			{
				get
				{
					return solution;
				}
				set	
				{
					solution = value;
				}
			}

			public List<string> StepList
			{
				get
				{
					return stepList;
				}
				set	
				{
					stepList = value;
				}
			}
		}
	}
}
