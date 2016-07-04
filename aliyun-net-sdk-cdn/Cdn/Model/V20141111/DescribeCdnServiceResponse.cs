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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeCdnServiceResponse : AcsResponse
	{

		private string internetChargeType;

		private string openingTime;

		private string changingChargeType;

		private string changingAffectTime;

		private List<LockReason> operationLocks;

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
			}
		}

		public string OpeningTime
		{
			get
			{
				return openingTime;
			}
			set	
			{
				openingTime = value;
			}
		}

		public string ChangingChargeType
		{
			get
			{
				return changingChargeType;
			}
			set	
			{
				changingChargeType = value;
			}
		}

		public string ChangingAffectTime
		{
			get
			{
				return changingAffectTime;
			}
			set	
			{
				changingAffectTime = value;
			}
		}

		public List<LockReason> OperationLocks
		{
			get
			{
				return operationLocks;
			}
			set	
			{
				operationLocks = value;
			}
		}

		public class LockReason{

			private string lockReason_;

			public string LockReason_
			{
				get
				{
					return lockReason_;
				}
				set	
				{
					lockReason_ = value;
				}
			}
		}
	}
}