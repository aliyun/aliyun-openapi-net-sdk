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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
	public class DescribeDdosCreditResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeDdosCredit_DdosCredit ddosCredit;

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

		public DescribeDdosCredit_DdosCredit DdosCredit
		{
			get
			{
				return ddosCredit;
			}
			set	
			{
				ddosCredit = value;
			}
		}

		public class DescribeDdosCredit_DdosCredit
		{

			private int? score;

			private string scoreLevel;

			private int? blackholeTime;

			public int? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string ScoreLevel
			{
				get
				{
					return scoreLevel;
				}
				set	
				{
					scoreLevel = value;
				}
			}

			public int? BlackholeTime
			{
				get
				{
					return blackholeTime;
				}
				set	
				{
					blackholeTime = value;
				}
			}
		}
	}
}
