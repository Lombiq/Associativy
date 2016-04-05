/*
** NOTE: This file is generated by Gulp and should not be edited directly!
** Any changes made directly to this file will be overwritten next time its asset group is processed by Gulp.
*/

/* http://keith-wood.name/calendars.html
   Islamic calendar for jQuery v2.0.1.
   Written by Keith Wood (kbwood{at}iinet.com.au) August 2009.
   Available under the MIT (http://keith-wood.name/licence.html) license. 
   Please attribute the author if you use it. */

(function($) { // Hide scope, no $ conflict

	/** Implementation of the Islamic or '16 civil' calendar.
		Based on code from <a href="http://www.iranchamber.com/calendar/converter/iranian_calendar_converter.php">http://www.iranchamber.com/calendar/converter/iranian_calendar_converter.php</a>.
		See also <a href="http://en.wikipedia.org/wiki/Islamic_calendar">http://en.wikipedia.org/wiki/Islamic_calendar</a>.
		@class IslamicCalendar
		@param [language=''] {string} The language code (default English) for localisation. */
	function IslamicCalendar(language) {
		this.local = this.regionalOptions[language || ''] || this.regionalOptions[''];
	}

	IslamicCalendar.prototype = new $.calendars.baseCalendar;

	$.extend(IslamicCalendar.prototype, {
		/** The calendar name.
			@memberof IslamicCalendar */
		name: 'Islamic',
		/** Julian date of start of Islamic epoch: 16 July 622 CE.
			@memberof IslamicCalendar */
		jdEpoch: 1948439.5,
		/** Days per month in a common year.
			@memberof IslamicCalendar */
		daysPerMonth: [30, 29, 30, 29, 30, 29, 30, 29, 30, 29, 30, 29],
		/** <code>true</code> if has a year zero, <code>false</code> if not.
			@memberof IslamicCalendar */
		hasYearZero: false,
		/** The minimum month number.
			@memberof IslamicCalendar */
		minMonth: 1,
		/** The first month in the year.
			@memberof IslamicCalendar */
		firstMonth: 1,
		/** The minimum day number.
			@memberof IslamicCalendar */
		minDay: 1,

		/** Localisations for the plugin.
			Entries are objects indexed by the language code ('' being the default US/English).
			Each object has the following attributes.
			@memberof IslamicCalendar
			@property name {string} The calendar name.
			@property epochs {string[]} The epoch names.
			@property monthNames {string[]} The long names of the months of the year.
			@property monthNamesShort {string[]} The short names of the months of the year.
			@property dayNames {string[]} The long names of the days of the week.
			@property dayNamesShort {string[]} The short names of the days of the week.
			@property dayNamesMin {string[]} The minimal names of the days of the week.
			@property dateFormat {string} The date format for this calendar.
					See the options on <a href="BaseCalendar.html#formatDate"><code>formatDate</code></a> for details.
			@property firstDay {number} The number of the first day of the week, starting at 0.
			@property isRTL {number} <code>true</code> if this localisation reads right-to-left. */
		regionalOptions: { // Localisations
			'': {
				name: 'Islamic',
				epochs: ['BH', 'AH'],
				monthNames: ['Muharram', 'Safar', 'Rabi\' al-awwal', 'Rabi\' al-thani', 'Jumada al-awwal', 'Jumada al-thani',
				'Rajab', 'Sha\'aban', 'Ramadan', 'Shawwal', 'Dhu al-Qi\'dah', 'Dhu al-Hijjah'],
				monthNamesShort: ['Muh', 'Saf', 'Rab1', 'Rab2', 'Jum1', 'Jum2', 'Raj', 'Sha\'', 'Ram', 'Shaw', 'DhuQ', 'DhuH'],
				dayNames: ['Yawm al-ahad', 'Yawm al-ithnayn', 'Yawm ath-thulaathaa\'',
				'Yawm al-arbi\'aa\'', 'Yawm al-khamīs', 'Yawm al-jum\'a', 'Yawm as-sabt'],
				dayNamesShort: ['Aha', 'Ith', 'Thu', 'Arb', 'Kha', 'Jum', 'Sab'],
				dayNamesMin: ['Ah','It','Th','Ar','Kh','Ju','Sa'],
				dateFormat: 'yyyy/mm/dd',
				firstDay: 6,
				isRTL: false
			}
		},

		/** Determine whether this date is in a leap year.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to examine or the year to examine.
			@return {boolean} <code>true</code> if this is a leap year, <code>false</code> if not.
			@throws Error if an invalid year or a different calendar used. */
		leapYear: function(year) {
			var date = this._validate(year, this.minMonth, this.minDay, $.calendars.local.invalidYear);
			return (date.year() * 11 + 14) % 30 < 11;
		},

		/** Determine the week of the year for a date.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to examine or the year to examine.
			@param [month] {number} The month to examine.
			@param [day] {number} The day to examine.
			@return {number} The week of the year.
			@throws Error if an invalid date or a different calendar used. */
		weekOfYear: function(year, month, day) {
			// Find Sunday of this week starting on Sunday
			var checkDate = this.newDate(year, month, day);
			checkDate.add(-checkDate.dayOfWeek(), 'd');
			return Math.floor((checkDate.dayOfYear() - 1) / 7) + 1;
		},

		/** Retrieve the number of days in a year.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to examine or the year to examine.
			@return {number} The number of days.
			@throws Error if an invalid year or a different calendar used. */
		daysInYear: function(year) {
			return (this.leapYear(year) ? 355 : 354);
		},

		/** Retrieve the number of days in a month.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to examine or the year of the month.
			@param [month] {number} The month.
			@return {number} The number of days in this month.
			@throws Error if an invalid month/year or a different calendar used. */
		daysInMonth: function(year, month) {
			var date = this._validate(year, month, this.minDay, $.calendars.local.invalidMonth);
			return this.daysPerMonth[date.month() - 1] +
				(date.month() === 12 && this.leapYear(date.year()) ? 1 : 0);
		},

		/** Determine whether this date is a week day.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to examine or the year to examine.
			@param [month] {number} The month to examine.
			@param [day] {number} The day to examine.
			@return {boolean} <code>true</code> if a week day, <code>false</code> if not.
			@throws Error if an invalid date or a different calendar used. */
		weekDay: function(year, month, day) {
			return this.dayOfWeek(year, month, day) !== 5;
		},

		/** Retrieve the Julian date equivalent for this date,
			i.e. days since January 1, 4713 BCE Greenwich noon.
			@memberof IslamicCalendar
			@param year {CDate|number} The date to convert or the year to convert.
			@param [month] {number} The month to convert.
			@param [day] {number} The day to convert.
			@return {number} The equivalent Julian date.
			@throws Error if an invalid date or a different calendar used. */
		toJD: function(year, month, day) {
			var date = this._validate(year, month, day, $.calendars.local.invalidDate);
			year = date.year();
			month = date.month();
			day = date.day();
			year = (year <= 0 ? year + 1 : year);
			return day + Math.ceil(29.5 * (month - 1)) + (year - 1) * 354 +
				Math.floor((3 + (11 * year)) / 30) + this.jdEpoch - 1;
		},

		/** Create a new date from a Julian date.
			@memberof IslamicCalendar
			@param jd {number} The Julian date to convert.
			@return {CDate} The equivalent date. */
		fromJD: function(jd) {
			jd = Math.floor(jd) + 0.5;
			var year = Math.floor((30 * (jd - this.jdEpoch) + 10646) / 10631);
			year = (year <= 0 ? year - 1 : year);
			var month = Math.min(12, Math.ceil((jd - 29 - this.toJD(year, 1, 1)) / 29.5) + 1);
			var day = jd - this.toJD(year, month, 1) + 1;
			return this.newDate(year, month, day);
		}
	});

	// Islamic (16 civil) calendar implementation
	$.calendars.calendars.islamic = IslamicCalendar;

})(jQuery);
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImpxdWVyeS5jYWxlbmRhcnMuaXNsYW1pYy5qcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsQUFMQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSIsImZpbGUiOiJqcXVlcnkuY2FsZW5kYXJzLmlzbGFtaWMuanMiLCJzb3VyY2VzQ29udGVudCI6WyIvKiBodHRwOi8va2VpdGgtd29vZC5uYW1lL2NhbGVuZGFycy5odG1sXG4gICBJc2xhbWljIGNhbGVuZGFyIGZvciBqUXVlcnkgdjIuMC4xLlxuICAgV3JpdHRlbiBieSBLZWl0aCBXb29kIChrYndvb2R7YXR9aWluZXQuY29tLmF1KSBBdWd1c3QgMjAwOS5cbiAgIEF2YWlsYWJsZSB1bmRlciB0aGUgTUlUIChodHRwOi8va2VpdGgtd29vZC5uYW1lL2xpY2VuY2UuaHRtbCkgbGljZW5zZS4gXG4gICBQbGVhc2UgYXR0cmlidXRlIHRoZSBhdXRob3IgaWYgeW91IHVzZSBpdC4gKi9cblxuKGZ1bmN0aW9uKCQpIHsgLy8gSGlkZSBzY29wZSwgbm8gJCBjb25mbGljdFxuXG5cdC8qKiBJbXBsZW1lbnRhdGlvbiBvZiB0aGUgSXNsYW1pYyBvciAnMTYgY2l2aWwnIGNhbGVuZGFyLlxuXHRcdEJhc2VkIG9uIGNvZGUgZnJvbSA8YSBocmVmPVwiaHR0cDovL3d3dy5pcmFuY2hhbWJlci5jb20vY2FsZW5kYXIvY29udmVydGVyL2lyYW5pYW5fY2FsZW5kYXJfY29udmVydGVyLnBocFwiPmh0dHA6Ly93d3cuaXJhbmNoYW1iZXIuY29tL2NhbGVuZGFyL2NvbnZlcnRlci9pcmFuaWFuX2NhbGVuZGFyX2NvbnZlcnRlci5waHA8L2E+LlxuXHRcdFNlZSBhbHNvIDxhIGhyZWY9XCJodHRwOi8vZW4ud2lraXBlZGlhLm9yZy93aWtpL0lzbGFtaWNfY2FsZW5kYXJcIj5odHRwOi8vZW4ud2lraXBlZGlhLm9yZy93aWtpL0lzbGFtaWNfY2FsZW5kYXI8L2E+LlxuXHRcdEBjbGFzcyBJc2xhbWljQ2FsZW5kYXJcblx0XHRAcGFyYW0gW2xhbmd1YWdlPScnXSB7c3RyaW5nfSBUaGUgbGFuZ3VhZ2UgY29kZSAoZGVmYXVsdCBFbmdsaXNoKSBmb3IgbG9jYWxpc2F0aW9uLiAqL1xuXHRmdW5jdGlvbiBJc2xhbWljQ2FsZW5kYXIobGFuZ3VhZ2UpIHtcblx0XHR0aGlzLmxvY2FsID0gdGhpcy5yZWdpb25hbE9wdGlvbnNbbGFuZ3VhZ2UgfHwgJyddIHx8IHRoaXMucmVnaW9uYWxPcHRpb25zWycnXTtcblx0fVxuXG5cdElzbGFtaWNDYWxlbmRhci5wcm90b3R5cGUgPSBuZXcgJC5jYWxlbmRhcnMuYmFzZUNhbGVuZGFyO1xuXG5cdCQuZXh0ZW5kKElzbGFtaWNDYWxlbmRhci5wcm90b3R5cGUsIHtcblx0XHQvKiogVGhlIGNhbGVuZGFyIG5hbWUuXG5cdFx0XHRAbWVtYmVyb2YgSXNsYW1pY0NhbGVuZGFyICovXG5cdFx0bmFtZTogJ0lzbGFtaWMnLFxuXHRcdC8qKiBKdWxpYW4gZGF0ZSBvZiBzdGFydCBvZiBJc2xhbWljIGVwb2NoOiAxNiBKdWx5IDYyMiBDRS5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXIgKi9cblx0XHRqZEVwb2NoOiAxOTQ4NDM5LjUsXG5cdFx0LyoqIERheXMgcGVyIG1vbnRoIGluIGEgY29tbW9uIHllYXIuXG5cdFx0XHRAbWVtYmVyb2YgSXNsYW1pY0NhbGVuZGFyICovXG5cdFx0ZGF5c1Blck1vbnRoOiBbMzAsIDI5LCAzMCwgMjksIDMwLCAyOSwgMzAsIDI5LCAzMCwgMjksIDMwLCAyOV0sXG5cdFx0LyoqIDxjb2RlPnRydWU8L2NvZGU+IGlmIGhhcyBhIHllYXIgemVybywgPGNvZGU+ZmFsc2U8L2NvZGU+IGlmIG5vdC5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXIgKi9cblx0XHRoYXNZZWFyWmVybzogZmFsc2UsXG5cdFx0LyoqIFRoZSBtaW5pbXVtIG1vbnRoIG51bWJlci5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXIgKi9cblx0XHRtaW5Nb250aDogMSxcblx0XHQvKiogVGhlIGZpcnN0IG1vbnRoIGluIHRoZSB5ZWFyLlxuXHRcdFx0QG1lbWJlcm9mIElzbGFtaWNDYWxlbmRhciAqL1xuXHRcdGZpcnN0TW9udGg6IDEsXG5cdFx0LyoqIFRoZSBtaW5pbXVtIGRheSBudW1iZXIuXG5cdFx0XHRAbWVtYmVyb2YgSXNsYW1pY0NhbGVuZGFyICovXG5cdFx0bWluRGF5OiAxLFxuXG5cdFx0LyoqIExvY2FsaXNhdGlvbnMgZm9yIHRoZSBwbHVnaW4uXG5cdFx0XHRFbnRyaWVzIGFyZSBvYmplY3RzIGluZGV4ZWQgYnkgdGhlIGxhbmd1YWdlIGNvZGUgKCcnIGJlaW5nIHRoZSBkZWZhdWx0IFVTL0VuZ2xpc2gpLlxuXHRcdFx0RWFjaCBvYmplY3QgaGFzIHRoZSBmb2xsb3dpbmcgYXR0cmlidXRlcy5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXJcblx0XHRcdEBwcm9wZXJ0eSBuYW1lIHtzdHJpbmd9IFRoZSBjYWxlbmRhciBuYW1lLlxuXHRcdFx0QHByb3BlcnR5IGVwb2NocyB7c3RyaW5nW119IFRoZSBlcG9jaCBuYW1lcy5cblx0XHRcdEBwcm9wZXJ0eSBtb250aE5hbWVzIHtzdHJpbmdbXX0gVGhlIGxvbmcgbmFtZXMgb2YgdGhlIG1vbnRocyBvZiB0aGUgeWVhci5cblx0XHRcdEBwcm9wZXJ0eSBtb250aE5hbWVzU2hvcnQge3N0cmluZ1tdfSBUaGUgc2hvcnQgbmFtZXMgb2YgdGhlIG1vbnRocyBvZiB0aGUgeWVhci5cblx0XHRcdEBwcm9wZXJ0eSBkYXlOYW1lcyB7c3RyaW5nW119IFRoZSBsb25nIG5hbWVzIG9mIHRoZSBkYXlzIG9mIHRoZSB3ZWVrLlxuXHRcdFx0QHByb3BlcnR5IGRheU5hbWVzU2hvcnQge3N0cmluZ1tdfSBUaGUgc2hvcnQgbmFtZXMgb2YgdGhlIGRheXMgb2YgdGhlIHdlZWsuXG5cdFx0XHRAcHJvcGVydHkgZGF5TmFtZXNNaW4ge3N0cmluZ1tdfSBUaGUgbWluaW1hbCBuYW1lcyBvZiB0aGUgZGF5cyBvZiB0aGUgd2Vlay5cblx0XHRcdEBwcm9wZXJ0eSBkYXRlRm9ybWF0IHtzdHJpbmd9IFRoZSBkYXRlIGZvcm1hdCBmb3IgdGhpcyBjYWxlbmRhci5cblx0XHRcdFx0XHRTZWUgdGhlIG9wdGlvbnMgb24gPGEgaHJlZj1cIkJhc2VDYWxlbmRhci5odG1sI2Zvcm1hdERhdGVcIj48Y29kZT5mb3JtYXREYXRlPC9jb2RlPjwvYT4gZm9yIGRldGFpbHMuXG5cdFx0XHRAcHJvcGVydHkgZmlyc3REYXkge251bWJlcn0gVGhlIG51bWJlciBvZiB0aGUgZmlyc3QgZGF5IG9mIHRoZSB3ZWVrLCBzdGFydGluZyBhdCAwLlxuXHRcdFx0QHByb3BlcnR5IGlzUlRMIHtudW1iZXJ9IDxjb2RlPnRydWU8L2NvZGU+IGlmIHRoaXMgbG9jYWxpc2F0aW9uIHJlYWRzIHJpZ2h0LXRvLWxlZnQuICovXG5cdFx0cmVnaW9uYWxPcHRpb25zOiB7IC8vIExvY2FsaXNhdGlvbnNcblx0XHRcdCcnOiB7XG5cdFx0XHRcdG5hbWU6ICdJc2xhbWljJyxcblx0XHRcdFx0ZXBvY2hzOiBbJ0JIJywgJ0FIJ10sXG5cdFx0XHRcdG1vbnRoTmFtZXM6IFsnTXVoYXJyYW0nLCAnU2FmYXInLCAnUmFiaVxcJyBhbC1hd3dhbCcsICdSYWJpXFwnIGFsLXRoYW5pJywgJ0p1bWFkYSBhbC1hd3dhbCcsICdKdW1hZGEgYWwtdGhhbmknLFxuXHRcdFx0XHQnUmFqYWInLCAnU2hhXFwnYWJhbicsICdSYW1hZGFuJywgJ1NoYXd3YWwnLCAnRGh1IGFsLVFpXFwnZGFoJywgJ0RodSBhbC1IaWpqYWgnXSxcblx0XHRcdFx0bW9udGhOYW1lc1Nob3J0OiBbJ011aCcsICdTYWYnLCAnUmFiMScsICdSYWIyJywgJ0p1bTEnLCAnSnVtMicsICdSYWonLCAnU2hhXFwnJywgJ1JhbScsICdTaGF3JywgJ0RodVEnLCAnRGh1SCddLFxuXHRcdFx0XHRkYXlOYW1lczogWydZYXdtIGFsLWFoYWQnLCAnWWF3bSBhbC1pdGhuYXluJywgJ1lhd20gYXRoLXRodWxhYXRoYWFcXCcnLFxuXHRcdFx0XHQnWWF3bSBhbC1hcmJpXFwnYWFcXCcnLCAnWWF3bSBhbC1raGFtxKtzJywgJ1lhd20gYWwtanVtXFwnYScsICdZYXdtIGFzLXNhYnQnXSxcblx0XHRcdFx0ZGF5TmFtZXNTaG9ydDogWydBaGEnLCAnSXRoJywgJ1RodScsICdBcmInLCAnS2hhJywgJ0p1bScsICdTYWInXSxcblx0XHRcdFx0ZGF5TmFtZXNNaW46IFsnQWgnLCdJdCcsJ1RoJywnQXInLCdLaCcsJ0p1JywnU2EnXSxcblx0XHRcdFx0ZGF0ZUZvcm1hdDogJ3l5eXkvbW0vZGQnLFxuXHRcdFx0XHRmaXJzdERheTogNixcblx0XHRcdFx0aXNSVEw6IGZhbHNlXG5cdFx0XHR9XG5cdFx0fSxcblxuXHRcdC8qKiBEZXRlcm1pbmUgd2hldGhlciB0aGlzIGRhdGUgaXMgaW4gYSBsZWFwIHllYXIuXG5cdFx0XHRAbWVtYmVyb2YgSXNsYW1pY0NhbGVuZGFyXG5cdFx0XHRAcGFyYW0geWVhciB7Q0RhdGV8bnVtYmVyfSBUaGUgZGF0ZSB0byBleGFtaW5lIG9yIHRoZSB5ZWFyIHRvIGV4YW1pbmUuXG5cdFx0XHRAcmV0dXJuIHtib29sZWFufSA8Y29kZT50cnVlPC9jb2RlPiBpZiB0aGlzIGlzIGEgbGVhcCB5ZWFyLCA8Y29kZT5mYWxzZTwvY29kZT4gaWYgbm90LlxuXHRcdFx0QHRocm93cyBFcnJvciBpZiBhbiBpbnZhbGlkIHllYXIgb3IgYSBkaWZmZXJlbnQgY2FsZW5kYXIgdXNlZC4gKi9cblx0XHRsZWFwWWVhcjogZnVuY3Rpb24oeWVhcikge1xuXHRcdFx0dmFyIGRhdGUgPSB0aGlzLl92YWxpZGF0ZSh5ZWFyLCB0aGlzLm1pbk1vbnRoLCB0aGlzLm1pbkRheSwgJC5jYWxlbmRhcnMubG9jYWwuaW52YWxpZFllYXIpO1xuXHRcdFx0cmV0dXJuIChkYXRlLnllYXIoKSAqIDExICsgMTQpICUgMzAgPCAxMTtcblx0XHR9LFxuXG5cdFx0LyoqIERldGVybWluZSB0aGUgd2VlayBvZiB0aGUgeWVhciBmb3IgYSBkYXRlLlxuXHRcdFx0QG1lbWJlcm9mIElzbGFtaWNDYWxlbmRhclxuXHRcdFx0QHBhcmFtIHllYXIge0NEYXRlfG51bWJlcn0gVGhlIGRhdGUgdG8gZXhhbWluZSBvciB0aGUgeWVhciB0byBleGFtaW5lLlxuXHRcdFx0QHBhcmFtIFttb250aF0ge251bWJlcn0gVGhlIG1vbnRoIHRvIGV4YW1pbmUuXG5cdFx0XHRAcGFyYW0gW2RheV0ge251bWJlcn0gVGhlIGRheSB0byBleGFtaW5lLlxuXHRcdFx0QHJldHVybiB7bnVtYmVyfSBUaGUgd2VlayBvZiB0aGUgeWVhci5cblx0XHRcdEB0aHJvd3MgRXJyb3IgaWYgYW4gaW52YWxpZCBkYXRlIG9yIGEgZGlmZmVyZW50IGNhbGVuZGFyIHVzZWQuICovXG5cdFx0d2Vla09mWWVhcjogZnVuY3Rpb24oeWVhciwgbW9udGgsIGRheSkge1xuXHRcdFx0Ly8gRmluZCBTdW5kYXkgb2YgdGhpcyB3ZWVrIHN0YXJ0aW5nIG9uIFN1bmRheVxuXHRcdFx0dmFyIGNoZWNrRGF0ZSA9IHRoaXMubmV3RGF0ZSh5ZWFyLCBtb250aCwgZGF5KTtcblx0XHRcdGNoZWNrRGF0ZS5hZGQoLWNoZWNrRGF0ZS5kYXlPZldlZWsoKSwgJ2QnKTtcblx0XHRcdHJldHVybiBNYXRoLmZsb29yKChjaGVja0RhdGUuZGF5T2ZZZWFyKCkgLSAxKSAvIDcpICsgMTtcblx0XHR9LFxuXG5cdFx0LyoqIFJldHJpZXZlIHRoZSBudW1iZXIgb2YgZGF5cyBpbiBhIHllYXIuXG5cdFx0XHRAbWVtYmVyb2YgSXNsYW1pY0NhbGVuZGFyXG5cdFx0XHRAcGFyYW0geWVhciB7Q0RhdGV8bnVtYmVyfSBUaGUgZGF0ZSB0byBleGFtaW5lIG9yIHRoZSB5ZWFyIHRvIGV4YW1pbmUuXG5cdFx0XHRAcmV0dXJuIHtudW1iZXJ9IFRoZSBudW1iZXIgb2YgZGF5cy5cblx0XHRcdEB0aHJvd3MgRXJyb3IgaWYgYW4gaW52YWxpZCB5ZWFyIG9yIGEgZGlmZmVyZW50IGNhbGVuZGFyIHVzZWQuICovXG5cdFx0ZGF5c0luWWVhcjogZnVuY3Rpb24oeWVhcikge1xuXHRcdFx0cmV0dXJuICh0aGlzLmxlYXBZZWFyKHllYXIpID8gMzU1IDogMzU0KTtcblx0XHR9LFxuXG5cdFx0LyoqIFJldHJpZXZlIHRoZSBudW1iZXIgb2YgZGF5cyBpbiBhIG1vbnRoLlxuXHRcdFx0QG1lbWJlcm9mIElzbGFtaWNDYWxlbmRhclxuXHRcdFx0QHBhcmFtIHllYXIge0NEYXRlfG51bWJlcn0gVGhlIGRhdGUgdG8gZXhhbWluZSBvciB0aGUgeWVhciBvZiB0aGUgbW9udGguXG5cdFx0XHRAcGFyYW0gW21vbnRoXSB7bnVtYmVyfSBUaGUgbW9udGguXG5cdFx0XHRAcmV0dXJuIHtudW1iZXJ9IFRoZSBudW1iZXIgb2YgZGF5cyBpbiB0aGlzIG1vbnRoLlxuXHRcdFx0QHRocm93cyBFcnJvciBpZiBhbiBpbnZhbGlkIG1vbnRoL3llYXIgb3IgYSBkaWZmZXJlbnQgY2FsZW5kYXIgdXNlZC4gKi9cblx0XHRkYXlzSW5Nb250aDogZnVuY3Rpb24oeWVhciwgbW9udGgpIHtcblx0XHRcdHZhciBkYXRlID0gdGhpcy5fdmFsaWRhdGUoeWVhciwgbW9udGgsIHRoaXMubWluRGF5LCAkLmNhbGVuZGFycy5sb2NhbC5pbnZhbGlkTW9udGgpO1xuXHRcdFx0cmV0dXJuIHRoaXMuZGF5c1Blck1vbnRoW2RhdGUubW9udGgoKSAtIDFdICtcblx0XHRcdFx0KGRhdGUubW9udGgoKSA9PT0gMTIgJiYgdGhpcy5sZWFwWWVhcihkYXRlLnllYXIoKSkgPyAxIDogMCk7XG5cdFx0fSxcblxuXHRcdC8qKiBEZXRlcm1pbmUgd2hldGhlciB0aGlzIGRhdGUgaXMgYSB3ZWVrIGRheS5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXJcblx0XHRcdEBwYXJhbSB5ZWFyIHtDRGF0ZXxudW1iZXJ9IFRoZSBkYXRlIHRvIGV4YW1pbmUgb3IgdGhlIHllYXIgdG8gZXhhbWluZS5cblx0XHRcdEBwYXJhbSBbbW9udGhdIHtudW1iZXJ9IFRoZSBtb250aCB0byBleGFtaW5lLlxuXHRcdFx0QHBhcmFtIFtkYXldIHtudW1iZXJ9IFRoZSBkYXkgdG8gZXhhbWluZS5cblx0XHRcdEByZXR1cm4ge2Jvb2xlYW59IDxjb2RlPnRydWU8L2NvZGU+IGlmIGEgd2VlayBkYXksIDxjb2RlPmZhbHNlPC9jb2RlPiBpZiBub3QuXG5cdFx0XHRAdGhyb3dzIEVycm9yIGlmIGFuIGludmFsaWQgZGF0ZSBvciBhIGRpZmZlcmVudCBjYWxlbmRhciB1c2VkLiAqL1xuXHRcdHdlZWtEYXk6IGZ1bmN0aW9uKHllYXIsIG1vbnRoLCBkYXkpIHtcblx0XHRcdHJldHVybiB0aGlzLmRheU9mV2Vlayh5ZWFyLCBtb250aCwgZGF5KSAhPT0gNTtcblx0XHR9LFxuXG5cdFx0LyoqIFJldHJpZXZlIHRoZSBKdWxpYW4gZGF0ZSBlcXVpdmFsZW50IGZvciB0aGlzIGRhdGUsXG5cdFx0XHRpLmUuIGRheXMgc2luY2UgSmFudWFyeSAxLCA0NzEzIEJDRSBHcmVlbndpY2ggbm9vbi5cblx0XHRcdEBtZW1iZXJvZiBJc2xhbWljQ2FsZW5kYXJcblx0XHRcdEBwYXJhbSB5ZWFyIHtDRGF0ZXxudW1iZXJ9IFRoZSBkYXRlIHRvIGNvbnZlcnQgb3IgdGhlIHllYXIgdG8gY29udmVydC5cblx0XHRcdEBwYXJhbSBbbW9udGhdIHtudW1iZXJ9IFRoZSBtb250aCB0byBjb252ZXJ0LlxuXHRcdFx0QHBhcmFtIFtkYXldIHtudW1iZXJ9IFRoZSBkYXkgdG8gY29udmVydC5cblx0XHRcdEByZXR1cm4ge251bWJlcn0gVGhlIGVxdWl2YWxlbnQgSnVsaWFuIGRhdGUuXG5cdFx0XHRAdGhyb3dzIEVycm9yIGlmIGFuIGludmFsaWQgZGF0ZSBvciBhIGRpZmZlcmVudCBjYWxlbmRhciB1c2VkLiAqL1xuXHRcdHRvSkQ6IGZ1bmN0aW9uKHllYXIsIG1vbnRoLCBkYXkpIHtcblx0XHRcdHZhciBkYXRlID0gdGhpcy5fdmFsaWRhdGUoeWVhciwgbW9udGgsIGRheSwgJC5jYWxlbmRhcnMubG9jYWwuaW52YWxpZERhdGUpO1xuXHRcdFx0eWVhciA9IGRhdGUueWVhcigpO1xuXHRcdFx0bW9udGggPSBkYXRlLm1vbnRoKCk7XG5cdFx0XHRkYXkgPSBkYXRlLmRheSgpO1xuXHRcdFx0eWVhciA9ICh5ZWFyIDw9IDAgPyB5ZWFyICsgMSA6IHllYXIpO1xuXHRcdFx0cmV0dXJuIGRheSArIE1hdGguY2VpbCgyOS41ICogKG1vbnRoIC0gMSkpICsgKHllYXIgLSAxKSAqIDM1NCArXG5cdFx0XHRcdE1hdGguZmxvb3IoKDMgKyAoMTEgKiB5ZWFyKSkgLyAzMCkgKyB0aGlzLmpkRXBvY2ggLSAxO1xuXHRcdH0sXG5cblx0XHQvKiogQ3JlYXRlIGEgbmV3IGRhdGUgZnJvbSBhIEp1bGlhbiBkYXRlLlxuXHRcdFx0QG1lbWJlcm9mIElzbGFtaWNDYWxlbmRhclxuXHRcdFx0QHBhcmFtIGpkIHtudW1iZXJ9IFRoZSBKdWxpYW4gZGF0ZSB0byBjb252ZXJ0LlxuXHRcdFx0QHJldHVybiB7Q0RhdGV9IFRoZSBlcXVpdmFsZW50IGRhdGUuICovXG5cdFx0ZnJvbUpEOiBmdW5jdGlvbihqZCkge1xuXHRcdFx0amQgPSBNYXRoLmZsb29yKGpkKSArIDAuNTtcblx0XHRcdHZhciB5ZWFyID0gTWF0aC5mbG9vcigoMzAgKiAoamQgLSB0aGlzLmpkRXBvY2gpICsgMTA2NDYpIC8gMTA2MzEpO1xuXHRcdFx0eWVhciA9ICh5ZWFyIDw9IDAgPyB5ZWFyIC0gMSA6IHllYXIpO1xuXHRcdFx0dmFyIG1vbnRoID0gTWF0aC5taW4oMTIsIE1hdGguY2VpbCgoamQgLSAyOSAtIHRoaXMudG9KRCh5ZWFyLCAxLCAxKSkgLyAyOS41KSArIDEpO1xuXHRcdFx0dmFyIGRheSA9IGpkIC0gdGhpcy50b0pEKHllYXIsIG1vbnRoLCAxKSArIDE7XG5cdFx0XHRyZXR1cm4gdGhpcy5uZXdEYXRlKHllYXIsIG1vbnRoLCBkYXkpO1xuXHRcdH1cblx0fSk7XG5cblx0Ly8gSXNsYW1pYyAoMTYgY2l2aWwpIGNhbGVuZGFyIGltcGxlbWVudGF0aW9uXG5cdCQuY2FsZW5kYXJzLmNhbGVuZGFycy5pc2xhbWljID0gSXNsYW1pY0NhbGVuZGFyO1xuXG59KShqUXVlcnkpOyJdLCJzb3VyY2VSb290IjoiL3NvdXJjZS8ifQ==
