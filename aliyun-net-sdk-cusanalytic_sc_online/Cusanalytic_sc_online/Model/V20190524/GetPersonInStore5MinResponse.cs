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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class GetPersonInStore5MinResponse : AcsResponse
	{

		private bool? success;

		private string msg;

		private List<GetPersonInStore5Min_PersonInStore> personInStores;

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

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
			}
		}

		public List<GetPersonInStore5Min_PersonInStore> PersonInStores
		{
			get
			{
				return personInStores;
			}
			set	
			{
				personInStores = value;
			}
		}

		public class GetPersonInStore5Min_PersonInStore
		{

			private int? number;

			private long? time;

			public int? Number
			{
				get
				{
					return number;
				}
				set	
				{
					number = value;
				}
			}

			public long? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}
		}
	}
}
