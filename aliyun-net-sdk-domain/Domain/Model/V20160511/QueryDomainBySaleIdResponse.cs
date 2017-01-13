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

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class QueryDomainBySaleIdResponse : AcsResponse
	{

		private string userId;

		private string domainName;

		private string saleId;

		private string creationDate;

		private string expirationDate;

		private string domainRegType;

		private string englishHolder;

		private string chineseHolder;

		private string englishContactPerson;

		private string chineseContactPerson;

		private string holderEmail;

		private string transferOutStatus;

		private string safetyLock;

		private string transferLock;

		private bool? whoisProtected;

		private List<string> dnsList;

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
			}
		}

		public string CreationDate
		{
			get
			{
				return creationDate;
			}
			set	
			{
				creationDate = value;
			}
		}

		public string ExpirationDate
		{
			get
			{
				return expirationDate;
			}
			set	
			{
				expirationDate = value;
			}
		}

		public string DomainRegType
		{
			get
			{
				return domainRegType;
			}
			set	
			{
				domainRegType = value;
			}
		}

		public string EnglishHolder
		{
			get
			{
				return englishHolder;
			}
			set	
			{
				englishHolder = value;
			}
		}

		public string ChineseHolder
		{
			get
			{
				return chineseHolder;
			}
			set	
			{
				chineseHolder = value;
			}
		}

		public string EnglishContactPerson
		{
			get
			{
				return englishContactPerson;
			}
			set	
			{
				englishContactPerson = value;
			}
		}

		public string ChineseContactPerson
		{
			get
			{
				return chineseContactPerson;
			}
			set	
			{
				chineseContactPerson = value;
			}
		}

		public string HolderEmail
		{
			get
			{
				return holderEmail;
			}
			set	
			{
				holderEmail = value;
			}
		}

		public string TransferOutStatus
		{
			get
			{
				return transferOutStatus;
			}
			set	
			{
				transferOutStatus = value;
			}
		}

		public string SafetyLock
		{
			get
			{
				return safetyLock;
			}
			set	
			{
				safetyLock = value;
			}
		}

		public string TransferLock
		{
			get
			{
				return transferLock;
			}
			set	
			{
				transferLock = value;
			}
		}

		public bool? WhoisProtected
		{
			get
			{
				return whoisProtected;
			}
			set	
			{
				whoisProtected = value;
			}
		}

		public List<string> DnsList
		{
			get
			{
				return dnsList;
			}
			set	
			{
				dnsList = value;
			}
		}
	}
}