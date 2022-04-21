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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class QueryJobsWithResultResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private List<string> variableNames;

		private QueryJobsWithResult_Jobs jobs;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public string Message
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

		public List<string> VariableNames
		{
			get
			{
				return variableNames;
			}
			set	
			{
				variableNames = value;
			}
		}

		public QueryJobsWithResult_Jobs Jobs
		{
			get
			{
				return jobs;
			}
			set	
			{
				jobs = value;
			}
		}

		public class QueryJobsWithResult_Jobs
		{

			private int? pageNumber;

			private int? pageSize;

			private int? pageCount;

			private int? rowCount;

			private List<QueryJobsWithResult_Job> list;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? PageCount
			{
				get
				{
					return pageCount;
				}
				set	
				{
					pageCount = value;
				}
			}

			public int? RowCount
			{
				get
				{
					return rowCount;
				}
				set	
				{
					rowCount = value;
				}
			}

			public List<QueryJobsWithResult_Job> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryJobsWithResult_Job
			{

				private string status;

				private string statusName;

				private string jobFailureReason;

				private string id;

				private QueryJobsWithResult_LatestTask latestTask;

				public string Status
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

				public string StatusName
				{
					get
					{
						return statusName;
					}
					set	
					{
						statusName = value;
					}
				}

				public string JobFailureReason
				{
					get
					{
						return jobFailureReason;
					}
					set	
					{
						jobFailureReason = value;
					}
				}

				public string Id
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

				public QueryJobsWithResult_LatestTask LatestTask
				{
					get
					{
						return latestTask;
					}
					set	
					{
						latestTask = value;
					}
				}

				public class QueryJobsWithResult_LatestTask
				{

					private string status;

					private string taskEndReason;

					private bool? hasAnswered;

					private int? callDuration;

					private bool? hasReachedEndOfFlow;

					private string statusName;

					private long? callTime;

					private string callDurationDisplay;

					private bool? hasHangUpByRejection;

					private bool? hasLastPlaybackCompleted;

					private List<QueryJobsWithResult_Extra> extras;

					private List<QueryJobsWithResult_TagHit> tagHits;

					private List<QueryJobsWithResult_ExceptionCode> dialExceptionCodes;

					private QueryJobsWithResult_Contact contact;

					public string Status
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

					public string TaskEndReason
					{
						get
						{
							return taskEndReason;
						}
						set	
						{
							taskEndReason = value;
						}
					}

					public bool? HasAnswered
					{
						get
						{
							return hasAnswered;
						}
						set	
						{
							hasAnswered = value;
						}
					}

					public int? CallDuration
					{
						get
						{
							return callDuration;
						}
						set	
						{
							callDuration = value;
						}
					}

					public bool? HasReachedEndOfFlow
					{
						get
						{
							return hasReachedEndOfFlow;
						}
						set	
						{
							hasReachedEndOfFlow = value;
						}
					}

					public string StatusName
					{
						get
						{
							return statusName;
						}
						set	
						{
							statusName = value;
						}
					}

					public long? CallTime
					{
						get
						{
							return callTime;
						}
						set	
						{
							callTime = value;
						}
					}

					public string CallDurationDisplay
					{
						get
						{
							return callDurationDisplay;
						}
						set	
						{
							callDurationDisplay = value;
						}
					}

					public bool? HasHangUpByRejection
					{
						get
						{
							return hasHangUpByRejection;
						}
						set	
						{
							hasHangUpByRejection = value;
						}
					}

					public bool? HasLastPlaybackCompleted
					{
						get
						{
							return hasLastPlaybackCompleted;
						}
						set	
						{
							hasLastPlaybackCompleted = value;
						}
					}

					public List<QueryJobsWithResult_Extra> Extras
					{
						get
						{
							return extras;
						}
						set	
						{
							extras = value;
						}
					}

					public List<QueryJobsWithResult_TagHit> TagHits
					{
						get
						{
							return tagHits;
						}
						set	
						{
							tagHits = value;
						}
					}

					public List<QueryJobsWithResult_ExceptionCode> DialExceptionCodes
					{
						get
						{
							return dialExceptionCodes;
						}
						set	
						{
							dialExceptionCodes = value;
						}
					}

					public QueryJobsWithResult_Contact Contact
					{
						get
						{
							return contact;
						}
						set	
						{
							contact = value;
						}
					}

					public class QueryJobsWithResult_Extra
					{

						private string key;

						private string _value;

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
					}

					public class QueryJobsWithResult_TagHit
					{

						private string tagName;

						private string tagGroup;

						public string TagName
						{
							get
							{
								return tagName;
							}
							set	
							{
								tagName = value;
							}
						}

						public string TagGroup
						{
							get
							{
								return tagGroup;
							}
							set	
							{
								tagGroup = value;
							}
						}
					}

					public class QueryJobsWithResult_ExceptionCode
					{

						private string code;

						private string hint;

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

						public string Hint
						{
							get
							{
								return hint;
							}
							set	
							{
								hint = value;
							}
						}
					}

					public class QueryJobsWithResult_Contact
					{

						private int? round;

						private string jobUuid;

						private string preferredPhoneNumber;

						private string phoneNumber;

						private string state;

						private string honorific;

						private string name;

						private string role;

						private string id;

						private string referenceId;

						public int? Round
						{
							get
							{
								return round;
							}
							set	
							{
								round = value;
							}
						}

						public string JobUuid
						{
							get
							{
								return jobUuid;
							}
							set	
							{
								jobUuid = value;
							}
						}

						public string PreferredPhoneNumber
						{
							get
							{
								return preferredPhoneNumber;
							}
							set	
							{
								preferredPhoneNumber = value;
							}
						}

						public string PhoneNumber
						{
							get
							{
								return phoneNumber;
							}
							set	
							{
								phoneNumber = value;
							}
						}

						public string State
						{
							get
							{
								return state;
							}
							set	
							{
								state = value;
							}
						}

						public string Honorific
						{
							get
							{
								return honorific;
							}
							set	
							{
								honorific = value;
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

						public string Role
						{
							get
							{
								return role;
							}
							set	
							{
								role = value;
							}
						}

						public string Id
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

						public string ReferenceId
						{
							get
							{
								return referenceId;
							}
							set	
							{
								referenceId = value;
							}
						}
					}
				}
			}
		}
	}
}
